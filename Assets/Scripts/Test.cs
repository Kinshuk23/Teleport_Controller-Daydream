using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject player;
    Ray ray;
    RaycastHit hit;

    private void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("1");
            if (hit.transform.CompareTag("Teleport"))
            {
                Debug.Log("2");
                //player.transform.position = hit.transform.position;
                player.transform.position = new Vector3(hit.transform.position.x, player.transform.position.y, hit.transform.position.z);
                //player.transform.position = new Vector3(hit.transform.position.x, player.transform.position.y, hit.transform.position.z);
            }
        }
    }

    /*public void TeleportFunc()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("Teleport"))
            {
                player.transform.position = new Vector3(hit.transform.position.x, player.transform.position.y, hit.transform.position.z);
            }
        }
    }*/
}