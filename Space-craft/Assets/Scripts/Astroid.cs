using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;
using System;

public class Astroid : MonoBehaviour
{
    GameObject[] Stars;
    Vector2 Velocity;
    // Start is called before the first frame update
    void Start()
    {
        Stars = GameObject.FindGameObjectsWithTag("star");
        Velocity = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Stars[1].transform.position, 2 * Time.deltaTime);
    }
}
