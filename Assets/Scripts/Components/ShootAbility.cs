using Systems.Interfaces;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Components {
	public class ShootAbility : MonoBehaviour, IAbility {
		public  float _shootDelay;
		private float _shootTime = float.MinValue;

		[SerializeField] private GameObject _bullet;

		private EntityManager _entityManager;
		private Entity        _bulletEntity;

		private void Awake() {
			var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld,
				null);
			// создали entity из префаба (но ещё не добавили на сцену, просто валяется в памяти)
			_bulletEntity = GameObjectConversionUtility.ConvertGameObjectHierarchy(_bullet, settings);
			// эта штука позволит нам добавить entity на сцену
			_entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
		}

		public void Execute() {
			if ( Time.time < _shootTime + _shootDelay ) {
				return;
			}

			SpawnBullet();

			_shootTime = Time.time;
		}

		private void SpawnBullet() {
			// это ссыль на созданный объект
			var instance = _entityManager.Instantiate(_bulletEntity);
			_entityManager.SetComponentData(instance,
				new Translation { Value = new float3(0, 0, 0) });
			_entityManager.SetComponentData(instance,
				new Rotation { Value = this.transform.rotation });
		}
	}
}