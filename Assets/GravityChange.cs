using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    private static BoxCollider gravityCube;
    // Start is called before the first frame update
    void Start()
    {
        gravityCube = this.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
