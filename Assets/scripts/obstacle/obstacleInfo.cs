using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleInfo : MonoBehaviour {
    public GameObject obs;
    public float speed = 2.0f;
    private void Start()
    {
        obs.transform.position = new Vector3(29.34f, -0.44f, 0);

    }
    void Update()
    {

        obs.transform.position -= new Vector3(speed * Time.deltaTime * (1), 0, 0);
   

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("충돌 : " + col.name);
    }
}
