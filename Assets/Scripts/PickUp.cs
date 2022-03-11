using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public virtual void Picked()
    {
        Debug.Log("Picked!");
        Destroy(this.gameObject);
    }

    private void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.Rotate(new Vector3(2f, 0f, 0f));
    }
}
