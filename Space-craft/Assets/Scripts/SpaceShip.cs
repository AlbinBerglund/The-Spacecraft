using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    Vector2 velocity;
    GameObject star_0;


    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(0, 0);
        star_0 = GameObject.Find("star_0");
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardControl();


    }

    void KeyboardControl()
    {
        int Speed = 4;

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }

         if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
    }
}
