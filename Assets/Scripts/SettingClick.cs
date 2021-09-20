using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingClick : MonoBehaviour
{
    public void clicked()
    {
        FindObjectOfType<Manager>().pauseClick();
    }
}
