using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public float Value = 100;
    public Animator Animator;

    public void DealDamage(float damage)
    {
        Value -= damage;
        if(Value <= 0)
        {
            EnemyDeath();
        }
    }

    private void EnemyDeath()
    {
        Animator.SetTrigger("death");
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
    }
}
