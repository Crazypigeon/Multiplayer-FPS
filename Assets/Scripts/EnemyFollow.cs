using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent enemy;
    GameObject player;
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.transform.position);
        Debug.Log("Following" + player.name);
    }
}
