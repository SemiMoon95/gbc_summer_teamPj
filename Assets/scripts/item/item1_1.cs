﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item1_1 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 7.2f;
    private void Start()
    {
        obs.transform.position = new Vector3(22.73f, 5.49f, 0);

    }
    void Update()
    {

        obs.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        obs.active = false;
    }
}
