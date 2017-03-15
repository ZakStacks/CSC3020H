using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rigidBody;
    public float speed;

    private void Start()    //called on first frame of this script
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()  //called before physics calculations
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidBody.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
        }
        Destroy(other.gameObject);  //all components, children and their components are destroyed
    }
}
