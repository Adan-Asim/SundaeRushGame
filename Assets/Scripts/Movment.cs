using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public NewBehaviourScript obj;
    public Transform parent;
    public Transform stack;

    public void OnCollisionEnter(Collision info)
    {
        obj = FindObjectOfType<NewBehaviourScript>();

        if (info.collider.tag == "Obstacle")
        {
            obj.enabled = false;
            FindObjectOfType<Manager>().endGame();
        }

        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GoodIngredient")
        {
            Transform otherTransform = other.transform;

            Rigidbody otherRB = otherTransform.GetComponent<Rigidbody>();
            otherRB.isKinematic = true;
            other.enabled = false;

          if(parent == null)
            {
                parent = otherTransform;
                parent.position = stack.position;
                parent.parent = stack;
                Debug.Log("1st");
                //parent.localScale = Vector3.one;
            }
            else
            {
                parent.position += Vector3.up * (otherTransform.localScale.y);
                otherTransform.position = stack.position;
                otherTransform.parent = parent;
                Debug.Log("2nd");
                //parent.localScale = Vector3.one;
            }
        }
    }

}
