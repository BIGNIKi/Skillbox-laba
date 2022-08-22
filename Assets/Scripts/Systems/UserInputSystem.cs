using Components;
using InputConfigs;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Systems {
	public class UserInputSystem : ComponentSystem {

		private InputMaster _inputMaster;
		private EntityQuery _inputQuery; // запрос на движение
		private float2      _moveInput;
		private bool        _rushInput;
		private float       _shootInput;

		// Запускается при создании системы (что-то типа awake)
		protected override void OnCreate() {
			// кешируем запрос, который будет искать все Entity с компонентом UserInputData
			_inputQuery = GetEntityQuery(ComponentType.ReadOnly<InputData>());

			_inputMaster = new InputMaster();
		}

		protected override void OnStartRunning() {
			AddMoveInputCallback();
			AddShootInputCallback();
			AddRushInputCallback();
		}

		private void AddMoveInputCallback() {
			_inputMaster.Player.move.performed += context => {
				_moveInput = context.ReadValue<Vector2>();
			};
			_inputMaster.Player.move.started += context => {
				_moveInput = context.ReadValue<Vector2>();
			};
			_inputMaster.Player.move.canceled += context => {
				_moveInput = context.ReadValue<Vector2>();
			};
			_inputMaster.Player.move.Enable();
		}

		private void AddShootInputCallback() {
			_inputMaster.Player.shoot.performed += context => {
				_shootInput = context.ReadValue<float>();
			};
			_inputMaster.Player.shoot.started += context => {
				_shootInput = context.ReadValue<float>();
			};
			_inputMaster.Player.shoot.canceled += context => {
				_shootInput = context.ReadValue<float>();
			};
			_inputMaster.Player.shoot.Enable();
		}
		
		private void AddRushInputCallback() {

			_inputMaster.Player.rush.performed += context => {};
			_inputMaster.Player.rush.started += context => {
				_rushInput = context.ReadValueAsButton();
			};
			_inputMaster.Player.rush.canceled += context => {
				_rushInput = context.ReadValueAsButton();
			};
			_inputMaster.Player.rush.Enable();
		}

		protected override void OnStopRunning() {
			_inputMaster.Player.move.Disable();
			_inputMaster.Player.shoot.Disable();
			_inputMaster.Player.rush.Disable();
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