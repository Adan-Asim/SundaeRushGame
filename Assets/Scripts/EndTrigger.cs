using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<Manager>().endLevel();
    }
}
