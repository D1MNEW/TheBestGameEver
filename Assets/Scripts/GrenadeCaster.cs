using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody GrenadePrefab;
    public Transform GrenadeSourceTransform;

    public float force = 500;
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            var Grenade = Instantiate(GrenadePrefab);
            Grenade.transform.position = GrenadeSourceTransform.position;
            Grenade.GetComponent<Rigidbody>().AddForce(GrenadeSourceTransform.forward * force);
        }
    }
}
