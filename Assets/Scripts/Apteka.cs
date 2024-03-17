using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apteka : MonoBehaviour
{
    public float HealAmount = 50;

    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if (PlayerHealth != null)
        {
            PlayerHealth.AddHealth(HealAmount);
            Destroy(gameObject);
        }
    }
}
