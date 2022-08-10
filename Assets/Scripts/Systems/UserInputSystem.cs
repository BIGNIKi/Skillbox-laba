using Unity.Entities;
using Unity.Mathematics;
using UnityEngine.InputSystem;

namespace Systems {
	public class UserInputSystem : ComponentSystem {
		private EntityQuery _inputQuery; // запрос на движение
		private InputAction _moveAction; // это наш ввод
		private float2      _moveInput;

		// Запускается при создании системы (что-то типа awake)
		protected override void OnCreate() {
			// кешируем запрос, который будет искать все Entity с компонентом UserInputData
			_inputQuery = GetEntityQuery(ComponentType.ReadOnly<UserInputData>());
		}
	// TODO: остановился на 4:50
		protected override void OnStartRunning() {
			//_moveAction = new InputAction()
		}

		protected override void OnUpdate() {
			throw new System.NotImplementedException();
		}
	}
}