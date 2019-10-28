
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroyer : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject);
        }
    }
}
© 2019 GitHub, Inc.
