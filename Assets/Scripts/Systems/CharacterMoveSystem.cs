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
					var deltaDirection = new Vector3(inputData.Move.x * moveData.Speed, 0, inputData.Move.y * moveData.Speed);
					pos += deltaDirection;

					var lengthOfVec = Mathf.Sqrt(inputData.Move.x * inputData.Move.x + inputData.Move.y * inputData.Move.y);
					if (!lengthOfVec.Equals(0f)) {
						transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(deltaDirection), Time.DeltaTime * 5f);
					}
					transform.position = pos;

					if (inputData.Rush) {
						transform.position += transform.forward;
					}
				});
		}
	}
}