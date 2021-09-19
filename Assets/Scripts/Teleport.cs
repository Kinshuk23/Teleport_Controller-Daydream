using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    //public new Transform camera;
    public Transform controller;
    
    Ray ray;
    RaycastHit hit;

   
    [System.Obsolete]
    void Update()
    {
        if (GvrControllerInput.ClickButtonDown)
        {
            Debug.Log("hi");
            //ray = new Ray(camera.transform.position, camera.forward);
            ray = new Ray(controller.transform.position, controller.forward);
            Debug.DrawRay(controller.transform.position, controller.forward, Color.green, 1);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log(hit.point);
                
                if (hit.transform.CompareTag("Teleport"))
                {
                    player.transform.position = new Vector3(hit.point.x, player.transform.position.y, hit.point.z);
                }
            }
        }
    }

    /*[System.Obsolete]
    public void TeleportFunc()
    {
        if (GvrControllerInput.ClickButtonUp)
        {
            player.transform.position = new Vector3(hit.transform.position.x, player.transform.position.y, hit.transform.position.z);
        }
    }*/

    /*[System.Obsolete]
    public void TeleportFunction()
    {
        if (GvrControllerInput.ClickButton)
        {
            Debug.Log("hi");
            //ray = new Ray(camera.transform.position, camera.forward);
            ray = new Ray(controller.transform.position, controller.forward);
            Debug.DrawRay(controller.transform.position, controller.forward);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("in Raycast");
                if (hit.transform.CompareTag("Teleport"))
                {
                    Debug.Log("Tag Checking");
                    //TeleportFunc();
                    player.transform.position = hit.transform.position;
                    //player.transform.position = new Vector3(hit.transform.position.x, player.transform.position.y, hit.transform.position.z);
                }
            }
        }
    }*/
}


