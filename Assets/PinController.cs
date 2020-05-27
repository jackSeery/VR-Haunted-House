using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    [SerializeField]
    private GameEvents current;
    public int id;
    private bool isFallen = false;
    private Rigidbody pinRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        current.onPinFall += OnPinFall;
        pinRigidBody = this.GetComponent<Rigidbody>();
        pinRigidBody.centerOfMass = new Vector3(0, 0.2f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject coll = collision.gameObject;
        if((coll.CompareTag("Ball") || coll.CompareTag("Pin")) && !isFallen)
        {
            this.OnPinFall();
        }
    }

    private void OnPinFall()
    {
        GameEvents.score++;
        GameEvents.current.UpdateScore();
        isFallen = true;
    }
}
