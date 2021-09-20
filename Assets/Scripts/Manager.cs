using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool hasEnded = false;
    public NewBehaviourScript obj;

    public void endGame()
    {
        if(hasEnded == false)
        {
            hasEnded = true;
            Invoke("Restart", 3f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<NewBehaviourScript>().enabled = true;
    }

    public GameObject Message;

    public void endLevel()
    {
        Message.SetActive(true);
        FindObjectOfType<NewBehaviourScript>().enabled = false;
    }

    public void pauseClick()
    {
        obj = FindObjectOfType<NewBehaviourScript>();
        Debug.Log("Clicked");

        if (obj.enabled == true)
        {
            obj.enabled = false;
            //GameObject.FindWithTag("SettingPanel").SetActive(true) ;
        }
        else
        {
            obj.enabled = true;
            //GameObject.FindWithTag("SettingPanel").SetActive(false);
        }
    }
}