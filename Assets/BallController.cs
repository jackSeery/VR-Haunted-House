using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private GameEvents current;
    private Transform ballTransform;
    private Rigidbody ballRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        current.onBallFall += OnBallFall;
        ballTransform = this.GetComponent<Transform>();
        ballRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ballTransform.position.y < -5)
        {
            this.OnBallFall();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(ballTransform.position.y < 0)
        {
            this.OnBallFall();
        }
    }

    public void OnBallFall()
    {
        Debug.Log("Ball fell off the world");
        ballTransform.position = new Vector3(0, 1, 27);
        ballRigidbody.velocity = new Vector3(0, 5, 0);
        ballRigidbody.angularVelocity = new Vector3(0, 0, 0);
        ballRigidbody.mass += 1.0f; //Just for fun, makes it easier to bowl over fallen pins as the ball gets heavier
        ballTransform.localScale = new Vector3(ballTransform.localScale.x * 1.05f, ballTransform.localScale.y * 1.05f, ballTransform.localScale.z * 1.05f); //Fucking increases the size of the ball every time it respawns why the fuck did I include this
    }
}
