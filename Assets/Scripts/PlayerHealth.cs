using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Value = 100;
    public RectTransform ValueRectTransform;
    public Animator Animator;

    public GameObject GameplayUI;
    public GameObject GameOverScreen;

    private float _maxValue;

    public void AddHealth(float Amount)
    {
        Value += Amount;
        Value = Mathf.Clamp(Value, 0, _maxValue);
        DrawHeathlBar();
    }

    private void Start()
    {
        _maxValue = Value;

        DrawHeathlBar();
    }
    public void DealDamage(float damage)
    {
        Value -= damage;
        if (Value <= 0)
        {
            PlayerIsDead();
        }

        DrawHeathlBar();
    }

    private void PlayerIsDead()
    {
        GameplayUI.SetActive(false);
        GameOverScreen.SetActive(true);

        Animator.SetTrigger("death");

        GetComponent<PlayerController>().enabled = false;
        GetComponent<FireballCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }
    private void DrawHeathlBar()
    {
        ValueRectTransform.anchorMax = new Vector2(Value / _maxValue, 1);
    }
}
