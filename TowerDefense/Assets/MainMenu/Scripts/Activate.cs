using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject activeGameObject;

    public void ActivateObject()
    {
        if(activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
        }
        else
        {
            activeGameObject.SetActive(false);
        }
    }
}
