using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = player.transform.position.x;
        float ypos = player.transform.position.y;
        float zpos = player.transform.position.z;

        transform.position = new Vector3(xpos, ypos+10, zpos-10);
    }
}
