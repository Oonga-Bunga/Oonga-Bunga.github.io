using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace EvilBunny
{
    public class EvilBunny : AKillableEntity
    {
        [SerializeField] private float _speed = 5f;
        [SerializeField] private NavMeshAgent _agent;

        private void Awake()
        {
            _currentHealth = _maxHealth;
            _hitbox = GetComponent<Collider>();
            _agent = GetComponent<NavMeshAgent>();
            _agent.speed = _speed;
        }

        public EvilBunny(float health) : base(health)
        {
            _agent = GetComponent<NavMeshAgent>();
            _agent.speed = _speed;
        }

        public override void TakeHit(float damage, IKillableEntity.AttackSource source)
        {
            switch (source)
            {
                case IKillableEntity.AttackSource.Flashlight:
                    ChangeHealth(damage, true);
                    break;
                case IKillableEntity.AttackSource.ClayBall:
                case IKillableEntity.AttackSource.Rocket:
                    ChangeHealth(MaxHealth, true);
                    break;
            }
        }

        public override void Die()
        {
            //generar partículas o algo, e incluso animación
            Debug.Log("hice la morición");
        }
    }
}

    
