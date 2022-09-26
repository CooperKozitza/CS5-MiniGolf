using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public GameObject obj;
    public Vector3 directionLeft;
    public Vector3 directionRight;
    public float bounciness = 1.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directionLeft = transform.TransformDirection(Vector3.left * bounciness);
        directionRight = transform.TransformDirection(Vector3.right * bounciness);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            obj = collision.gameObject;
            obj.GetComponent<Rigidbody>().AddForce(directionLeft + directionLeft, ForceMode.Impulse);
        }
    }
}
