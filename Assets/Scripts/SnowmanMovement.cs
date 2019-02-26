using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanMovement : MonoBehaviour
{
    private float speed = 15f;
    private float turnSpeed = 3.3f;
    private float rotationTime;
    private bool isKeyPressed = false;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            isKeyPressed = !isKeyPressed;
        }
    }

    void FixedUpdate()
    {

        if (isKeyPressed)
        {

            var pos = transform.position + transform.forward * 2;
            Ray downRay = new Ray(pos, transform.up * -1);
            if (!Physics.Raycast(downRay))
            {
                rotationTime = 2/ Random.Range(2f, 6f);
            }
            if (rotationTime > 0)
            {
                transform.Rotate(new Vector3(0, 1 * turnSpeed, 0));
                rotationTime -= Time.deltaTime;
            }
            else
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
        }

        
    }
}
