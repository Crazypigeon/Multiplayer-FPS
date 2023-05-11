using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventWallClip : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform t_camera;
    public Transform player;
    private RaycastHit hit;
    private Vector3 camera_offset;
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        camera_offset = t_camera.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        var position = new Vector3(player.position.x, player.position.y + 2, player.position.z);

        if (Physics.Linecast(position, t_camera.transform.position, out hit))
        {
            Debug.DrawLine(position, t_camera.transform.position, Color.red, 10);
            t_camera.localPosition = Vector3.Lerp(t_camera.localPosition, new Vector3(t_camera.localPosition.x, t_camera.localPosition.y, Vector3.Distance(t_camera.position, hit.point)), Time.deltaTime);
        }
        else
        {
            t_camera.localPosition = Vector3.Lerp(t_camera.localPosition, camera_offset, Time.deltaTime);
        }

        //Debug.DrawLine(transform.position, transform.position + transform.localRotation * camera_offset, Color.red, 10);
        //if (Physics.Linecast(transform.position,transform.position + transform.localRotation*camera_offset, out hit))
        //{

        //    t_camera.localPosition = Vector3.Lerp(t_camera.localPosition,new Vector3(t_camera.localPosition.x, t_camera.localPosition.y, -Vector3.Distance(transform.position, hit.point)),Time.deltaTime);
        //}
        //else
        //{
        //    t_camera.localPosition = Vector3.Lerp(t_camera.localPosition,camera_offset, Time.deltaTime);
        //}
    }
}
