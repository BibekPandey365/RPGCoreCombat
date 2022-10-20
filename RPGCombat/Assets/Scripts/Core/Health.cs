using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoint = 100f;

        bool isDead = false;


        public bool IsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            healthPoint = Mathf.Max(healthPoint - damage, 0f);
            print(healthPoint);

            if(healthPoint == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (isDead) return;
            GetComponent<Animator>().SetTrigger("die");
            isDead = true;

            GetComponent<ActionScheduler>().CancelCurrentAction();
        }
    }
}

