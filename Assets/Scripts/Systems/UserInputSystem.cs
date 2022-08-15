using Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Systems {
	public class UserInputSystem : ComponentSystem {
		private EntityQuery _inputQuery; // запрос на движение

		private InputAction _moveAction; // это наш ввод
		private InputAction _shootAction;
		private InputAction _rushAction;

		private float2 _moveInput;
		private float  _shootInput;
		private bool   _rushInput;

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
			// performed - это что-то типа GetMouseBtn - тоесть срабатывает всегда когда нажата клавиша
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

			_shootAction = new InputAction("shoot", binding: "<Keyboard>/Space");
			_shootAction.performed += context => {
				_shootInput = context.ReadValue<float>();
			};
			_shootAction.started += context => {
				_shootInput = context.ReadValue<float>();
			};
			_shootAction.canceled += context => {
				_shootInput = context.ReadValue<float>();
			};
			_shootAction.Enable();

			_rushAction           =  new InputAction("rush", binding: "<Keyboard>/R");
			_rushAction.performed += context => {};
			_rushAction.started += context => {
				_rushInput = context.ReadValueAsButton();
			};
			_rushAction.canceled += context => {
				_rushInput = context.ReadValueAsButton();
			};
			_rushAction.Enable();
		}

		protected override void OnStopRunning() {
			_moveAction.Disable();
			_shootAction.Disable();
			_rushAction.Disable();
		}

		protected override void OnUpdate() {
			Entities.With(_inputQuery).ForEach(
				(Entity entity, ref InputData inputData) => {
					inputData.Move  = _moveInput;
					inputData.Shoot = _shootInput;
					inputData.Rush  = _rushInput;
					_rushInput      = false;
				});
		}
	}
}