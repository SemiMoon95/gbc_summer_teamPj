using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAction : MonoBehaviour {
    bool jumpOn = false;
    float jumpPower = 0.75f;
    float tempJump;
    Transform playerTf;
    Vector3 tempVec;
    void Awake()
    {
        playerTf = transform;
    }

    void Update()
    {
        if (!jumpOn)
        {
            if ((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")))
            {
                StartCoroutine("JumpAction");
            }
        }
        
    }

    IEnumerator JumpAction()
    {
        jumpOn = true;
        tempVec = playerTf.position;

        tempJump = jumpPower;
        tempVec.y += tempJump;
        playerTf.position = tempVec;

        while (tempVec.y > 0.76f)
        {
            yield return new WaitForSeconds(0.03f);
            tempJump -= 0.05f;
            tempVec.y += tempJump;
            playerTf.position = tempVec;
        }
        tempVec.y = 0.76f;
        playerTf.position = tempVec;
        jumpOn = false;
    }
    
}
