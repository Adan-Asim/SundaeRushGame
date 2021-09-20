using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rg;
    public float forwardForce = 20f;
    public float turn = 1f;


    void Start()
    {
        //Debug.Log("Hello World");
        //rg.useGravity = false;

        rg = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rg.AddForce(0, 0, forwardForce);

/*      if (Input.GetKey("d"))
        {
            rg.AddForce(turn, 0, 0,ForceMode.VelocityChange);
        }
  
        else if (Input.GetKey("s"))
        {
            rg.AddForce(-1 * turn, 0, 0,ForceMode.VelocityChange);
        }
*/

        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray,out hit, 100))
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(hit.point.x, transform.position.y, transform.position.z), turn * Time.deltaTime);
            }
        }

        if(rg.position.y < -5)
        {
            FindObjectOfType<Manager>().endGame();
        }

    }
}
