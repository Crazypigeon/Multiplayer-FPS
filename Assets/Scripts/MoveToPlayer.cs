using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPlayer : MonoBehaviour
{
    public GameObject player;
    public float followSpeed = .01f;
    public int damage = 1;
    public bool takingDamage;
    NavMeshAgent enemy;
    private void Update()
    {
        player = GameObject.Find("PolicemanController(Clone)");

        //Vector3 targetPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);


        //transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        enemy.SetDestination(player.transform.position);

        transform.LookAt(player.transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            takingDamage = true;
            StartCoroutine(takeDamage());
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            takingDamage = false;
            StopCoroutine(takeDamage());
        }
    }


    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        takingDamage = false;
    }

    private IEnumerator takeDamage()
    {
        while (takingDamage)
        {
            player.GetComponent<PlayerHealth>().TakeDamage(damage, "Enemy");
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame

}
