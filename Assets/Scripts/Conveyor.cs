using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public float SpeedMultiplyer = 1;
    public float timeToSwitch = 5; 
    protected Vector2 textureOffset;

    // Start is called before the first frame update
    void Start()
    {
        textureOffset = GetComponent<Renderer>().material.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        textureOffset.y += SpeedMultiplyer * Time.deltaTime;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", textureOffset);

        timeToSwitch -= Time.deltaTime;
        if (timeToSwitch <= 0) {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                transform.eulerAngles.y + 180,
                transform.eulerAngles.z
            );
            timeToSwitch = 5;
        } 
    }
}
