using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2;
    public Rigidbody rb;
    public float forceAmount = 10;
    public float jumpAmount = 10;
    private bool isJumping;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x,0,z).normalized;
        movement = Vector3.ClampMagnitude(movement, 1);
        transform.Translate(movement*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

}
