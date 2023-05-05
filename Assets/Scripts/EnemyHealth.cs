using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    private int maxHalth;
    public ParticleSystem hitVFX;

    public Material enemyMaterial;

    public Color fullHealthColor;
    public Color lowHealthColor;

    public NextLevelLoader enemiesNumber;
    public MeshRenderer mesh;
    private void Awake()
    {
        enemyMaterial = mesh.material;
        maxHalth = health;
        enemyMaterial.color = fullHealthColor;
        enemiesNumber = GameObject.Find("NextLevelLoader").GetComponent<NextLevelLoader>();
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            enemiesNumber.enemyKilled();
        }


    }

    public void TakeDamage(int damage)
    {
        hitVFX.Play();
        health -= damage;
        ChangeColor();
    }
    public void ChangeColor()
    {
        enemyMaterial.color = Color.Lerp(lowHealthColor, fullHealthColor, (float)health / 100);
        enemyMaterial.SetColor("_EmissionColor", Color.Lerp(lowHealthColor, fullHealthColor, (float)health / 100));
    }
}
