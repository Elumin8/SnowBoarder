using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] SurfaceEffector2D surfaceEffector2D;
    [SerializeField] private float torqueAmmount = 1;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float slowSpeed = 10f;
    [SerializeField] private float regularSpeed = 20f;
    [SerializeField] public bool canMove = true;
    void Start()
    {
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
        //Same method - different realization.
        // float movement = Input.GetAxis("Horizontal") * Time.deltaTime;
        // if (movement > 0)
        // {
        //     rb2d.AddTorque(-torqueAmmount);
        // }
        // else if (movement < 0)
        // {
        //     rb2d.AddTorque(torqueAmmount);
        // }

    }

    public void DisableControls()
    {
        canMove = false;

    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            surfaceEffector2D.speed = slowSpeed;
        }
        else
        {
            surfaceEffector2D.speed = regularSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmmount);
        }
    }
}
