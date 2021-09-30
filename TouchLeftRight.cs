using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLeftRight : MonoBehaviour
{

    private float speed = 0.015f;
    private Touch touch;


    void Update()
    {

        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);



        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed,
                    transform.position.y, transform.position.z);
            }


        }
    }
}

