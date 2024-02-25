using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{

    public Fireball FireballPrefab;
    public Transform FireballSourceTransform;
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(FireballPrefab, FireballSourceTransform.position, FireballSourceTransform.rotation);
        }
    }
}
