using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item1 : MonoBehaviour
{
    public GameObject obs;
    public float speed = 7.2f;
    private void Start()
    {
        obs.transform.position = new Vector3(20.07f, 3.45f, 0);

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
