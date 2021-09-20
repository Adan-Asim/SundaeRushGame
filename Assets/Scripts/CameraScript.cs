using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void Update()
    {
        Vector3 temp = new Vector3 (0, player.position.y + offset.y, player.position.z + offset.z);
        transform.position = temp;
    }
}
