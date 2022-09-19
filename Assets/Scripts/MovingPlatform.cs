using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float SpeedMultiplyer = 0.5F;
    protected Vector3 StartingPosition { get; set;}

    // Start is called before the first frame update
    void Start()
    {
        StartingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(SpeedMultiplyer * Time.deltaTime, 0, 0), Space.Self);
        if (transform.position.x > StartingPosition.x + 0.25F) {
                SpeedMultiplyer *= -1.0F; 
                transform.position = new Vector3(StartingPosition.x + 0.25F, StartingPosition.y, StartingPosition.z);
        }
        if (transform.position.x < StartingPosition.x - 0.25F) {
                SpeedMultiplyer *= -1.0F; 
                transform.position = new Vector3(StartingPosition.x - 0.25F, StartingPosition.y, StartingPosition.z);
        }
    }
}
