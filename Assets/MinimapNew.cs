using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapNew : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    public static MinimapNew Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    public void AttachPlayer()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Player != null)
        {
            Vector3 newPosition = Player.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
    }
}
