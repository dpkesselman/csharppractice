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
    public float rotationSpeed;
    private float x;
    private float z;
    private Quaternion originalRotation;

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x,0,z).normalized;
        movement = Vector3.ClampMagnitude(movement, 1);
        transform.Translate(movement*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            isJumping = true;
        }

        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if (other.gameObject.CompareTag("Roots"))
        {
            rb.constraints = RigidbodyConstraints.None;  //Elimina los constraints.
            //StartCoroutine(WaitSecs());  
            transform.rotation = originalRotation;
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Limits"))
        {
            this.transform.Translate(Vector3.right * -x * Time.deltaTime);
            this.transform.Translate(Vector3.forward * -z * Time.deltaTime);
        }
    }


/*    IEnumerator WaitSecs()
    {
        yield return new WaitForSecondsRealtime(3);
    }
*/
}
