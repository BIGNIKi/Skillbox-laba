using Components;
using Systems.Interfaces;
using Unity.Entities;

namespace Systems {
	public class CharacterShootSystem : ComponentSystem {
		private EntityQuery _shootQuerry;

		protected override void OnCreate() {
			_shootQuerry = GetEntityQuery(
				ComponentType.ReadOnly<InputData>(),
				ComponentType.ReadOnly<ShootData>(),
				ComponentType.ReadOnly<UserInputData>());
		}

		protected override void OnUpdate() {
			Entities.With(_shootQuerry).ForEach(
				(Entity entity, UserInputData inputData, ref InputData input) => {
					if ( input.Shoot > 0f && inputData.ShootAction != null ) {
						if ( inputData.ShootAction is IAbility ability ) {
							ability.Execute();
						}
					}
				});
		}
	}
}