using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        if (gameObject.tag == "Player")
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }     
    }
}
