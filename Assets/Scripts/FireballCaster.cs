using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{

    public Fireball FireballPrefab;
    public Transform FireballSourceTransform;
    public Animator Animator;

    public PlayerController PlayerController;

    private void Start()
    {
        GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Animator.SetTrigger("attack");

            Instantiate(FireballPrefab, FireballSourceTransform.position, FireballSourceTransform.rotation);

            Animator.SetTrigger("idle");

            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        PlayerController.Speed = 0;

        yield return new WaitForSeconds(1);

        PlayerController.Speed = 5;
    }
}
