using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.GameObject.name == "Player")
        {
            collision.GameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.GameObject.name == "Player")
        {
            collision.GameObject.transform.SetParent(null);
        }
    }
}
