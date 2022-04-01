using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script should be assigned to ColliderPlane.
/// </summary>
public class PortalTeleport : MonoBehaviour
{
    public Transform player;
    public Transform receiver; //portal to which we teleport our player

    bool playerIsOverlapping = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerIsOverlapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }

    private void FixedUpdate()
    {
        Teleportation();
    }

    private void Teleportation()
    {
        Debug.DrawLine(transform.position, player.position, Color.red);

        if (playerIsOverlapping)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(portalToPlayer, transform.up);

            Debug.Log($"dotProduct: {dotProduct}");

            if(dotProduct > 0f)
            {
                float playerCapsuleColliderHalfOfHeight
                    = player.GetComponent<CharacterController>().height;
                player.position
                    = receiver.position + Vector3.up * playerCapsuleColliderHalfOfHeight;
            }
        }
    }
}
