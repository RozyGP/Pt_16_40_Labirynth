using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform closePosition;
    public Transform openPosition;
    public Transform door;

    public bool open = false;
    public float speed = 1f;

    private void Start()
    {
        door.position = closePosition.position;
    }

    private void Update()
    {
        if(open)
        {
            door.position = Vector3.MoveTowards(door.position,
                openPosition.position,
                speed * Time.deltaTime);
        }
        else
        {
            door.position = Vector3.MoveTowards(door.position,
                closePosition.position,
                speed * Time.deltaTime);
        }
    }

    public void CloseOpen()
    {
        open = !open;
    }
}
