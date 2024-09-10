using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    float currentMoveSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentMoveSpeed = moveSpeed;
        // transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * currentMoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        currentMoveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "SpeedBoost")
        {
            currentMoveSpeed = boostSpeed;
        }
    }
}
