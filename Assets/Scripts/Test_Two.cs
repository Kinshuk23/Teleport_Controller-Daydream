using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test_Two : MonoBehaviour
{

    public GameObject player;

    public void TeleportTo(BaseEventData data)
    {
        PointerEventData pointerData = data as PointerEventData;
        Vector3 worldPos = pointerData.pointerCurrentRaycast.worldPosition;
        Vector3 playerPos = new Vector3(worldPos.x, player.transform.position.y, worldPos.z);
        player.transform.position = playerPos;
    }

}
