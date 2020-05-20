using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusMovement : MonoBehaviour
{
    float timeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;

        float x = 40 * Mathf.Cos (timeCounter);
        float y = 0;
        float z = 40 * Mathf.Sin (timeCounter);

        transform.position = new Vector3 (x, y, z);
    }
}
