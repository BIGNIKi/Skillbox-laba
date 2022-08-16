using Unity.Entities;
using UnityEngine;

namespace Components {
	public class BulletMoveData : MonoBehaviour, IConvertGameObjectToEntity {
		[SerializeField] private float _speed;
		[SerializeField] private float _timeToExist;

		public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
			dstManager.AddComponentData(entity, new BulletData {
				Speed = _speed, 
				TimeToExist = _timeToExist,
				ActualExistingTime = 0f,
			});
		}
	}

	public struct BulletData : IComponentData {
		public float Speed;
		public float TimeToExist;
		public float ActualExistingTime;
		
		public bool ShouldDestroy() {
			if (ActualExistingTime >= TimeToExist) {
				return true;
			}
			return false;
		}
	}
}