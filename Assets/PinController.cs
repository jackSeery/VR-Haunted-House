using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onPinFall += OnPinFall;
    }

    private void OnPinFall()
    {
        GameEvents.score++;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.transform.rotation.x > 30 || this.gameObject.transform.rotation.z > 30)
        {
            GameEvents.current.PinFall();
            Destroy(this.gameObject);
        }
    }

}
