using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;

    void start()
    {
        speedModifier = 1f;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier, transform.position.y, transform.position.z + touch.deltaPosition.y * speedModifier);
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
         
                transform.position = Input.mousePosition;
        }
    }
}
 