using Components;
using Unity.Entities;
using UnityEngine;

namespace Systems {
	public class CharacterMoveSystem : ComponentSystem {
		private EntityQuery _moveQuerry;

		protected override void OnCreate() {
			_moveQuerry = GetEntityQuery(
				ComponentType.ReadOnly<InputData>(),
				ComponentType.ReadOnly<MoveData>(),
				ComponentType.ReadOnly<Transform>());
		}

		protected override void OnUpdate() {
			Entities.With(_moveQuerry).ForEach(
				( Entity entity, Transform transform, ref InputData inputData,  ref MoveData moveData) => {
					var pos = transform.position;
					pos += new Vector3(inputData.Move.x * moveData.Speed, 0, inputData.Move.y * moveData.Speed);

					transform.position = pos;
				});
		}
	}
}