using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Value = 100;
    public RectTransform ValueRectTransform;

    public GameObject GameplayUI;
    public GameObject GameOverScreen;

    private float _maxValue;

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

        GetComponent<PlayerController>().enabled = false;
        GetComponent<FireballCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }
    private void DrawHeathlBar()
    {
        ValueRectTransform.anchorMax = new Vector2(Value / _maxValue, 1);
    }
}
