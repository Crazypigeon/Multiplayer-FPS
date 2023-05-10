using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

            var spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnEnemy>();
        spawner.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
