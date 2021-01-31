using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDestroyScript : MonoBehaviour
{
    public GameObject DestroyEffect;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Dash")
        {
            Destroy(gameObject);
            Instantiate(DestroyEffect, transform.position, Quaternion.identity);
        }
    }
}
