using Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Systems {
	public class UserInputSystem : ComponentSystem {
		private EntityQuery _inputQuery; // запрос на движение
		private InputAction _moveAction; // это наш ввод
		private float2      _moveInput;

		// Запускается при создании системы (что-то типа awake)
		protected override void OnCreate() {
			// кешируем запрос, который будет искать все Entity с компонентом UserInputData
			_inputQuery = GetEntityQuery(ComponentType.ReadOnly<InputData>());
		}

		// TODO: остановился на 4:50
		protected override void OnStartRunning() {
			// создаем новое действие ввода с названием move
			// оно будет появляться как реакция на right stick на геймпаде
			_moveAction = new InputAction("move", binding: "<Gamepad>/rightStick");
			_moveAction.AddCompositeBinding("Dpad")
				.With("Up", "<Keyboard>/w")
				.With("Down", "<Keyboard>/s")
				.With("Left", "<Keyboard>/a")
				.With("Right", "<Keyboard>/d");

			// заполняем все делегаты (все возможные состояния устройства ввода)
			_moveAction.performed += context => {
				_moveInput = context.ReadValue<Vector2>();
			};
			_moveAction.started += context => {
				_moveInput = context.ReadValue<Vector2>();
			};
			_moveAction.canceled += context => {
				_moveInput = context.ReadValue<Vector2>();
			};
			_moveAction.Enable();
		}

		protected override void OnStopRunning() {
			_moveAction.Disable();
		}

		protected override void OnUpdate() {
			Entities.With(_inputQuery).ForEach(
				(Entity entity, ref InputData inputData) => {
					inputData.Move = _moveInput;
				});
		}
	}
}