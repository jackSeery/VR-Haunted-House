using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    public int id;
    private Vector3 pinDirection;
    private Vector3 fallenAngle = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(pinDirection.ToString());
        GameEvents.current.onPinFall += OnPinFall;
    }

    private void Update()
    {
        pinDirection = this.transform.localEulerAngles;
        Debug.Log("Pin " + this.id + " direction: " + pinDirection.ToString());

        Debug.Log("Angle between upright and Pin " + this.id + " direction: " + Vector3.Angle(fallenAngle, pinDirection));

        if (PinFallenOver(id))
        {
            Debug.Log("This Pin object is fallen over: " + this.id);
        }
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

    private bool PinFallenOver(int id)
    {
        return Vector3.Angle(fallenAngle, pinDirection) > 10.0f;
    }

}
