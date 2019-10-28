using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycarmove : MonoBehaviour
{

    public float speed;

    void Update()
    {
        transform.Translate (new Vector3(0f, Time.deltaTime * speed, 0f));
    }
}
