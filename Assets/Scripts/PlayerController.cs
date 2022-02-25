using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 12f;
    CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal"); //a -> -1, d -> 1
        float z = Input.GetAxis("Vertical"); //w -> 1, s -> -1

        //Vector3 move = Vector3.right * x + Vector3.forward * z; //bez obrotu
        Vector3 move = transform.right * x + transform.forward * z; //z obrotem
        characterController.Move(move * speed * Time.deltaTime);
    }
}
