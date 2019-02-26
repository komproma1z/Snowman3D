using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Snowman;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Snowman.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Snowman.transform.position + offset;
    }
}
