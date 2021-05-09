using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true;

    [SerializeField][Range(1,20)]  float moveSpeed;

    [SerializeField]float xPos;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Move();
        }

    }

    void Move()
    {
        float inputX = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float finalPos = Mathf.Clamp(transform.position.x, -xPos, xPos);

        transform.position = new Vector3(finalPos, transform.position.y, transform.position.z);
    }
}
