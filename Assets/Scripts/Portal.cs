using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portalOut = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (portalOut != null)
            {
                other.attachedRigidbody.velocity = new Vector3(0, 0, 0);
                other.transform.position = portalOut.transform.position;
            }
            else
            {
                Debug.Log("portalOut is NULL");
            }
        }
    }
}
