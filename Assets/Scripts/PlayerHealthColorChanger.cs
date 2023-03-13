using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthColorChanger : MonoBehaviour
{
    public Material material;
    public PlayerHealth health;

    public Color fullHealthColor;
    public Color lowHealthColor;

    private void Awake()
    {
        Debug.Log(health);
    }
    void Update()
    {
        //Debug.Log((float)health.currentHealth / 100);
        material.color = Color.Lerp(lowHealthColor, fullHealthColor, (float)health.currentHealth / 100);
        material.SetColor("_EmissionColor", material.color);
    }
}
