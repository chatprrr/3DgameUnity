using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZabiyakaController : MonoBehaviour
{
    Rigidbody rb;
    public int applecount;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyForce(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            ApplyForce(new Vector3(1, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            ApplyForce(new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.W))
        {
            ApplyForce(new Vector3(0, 0, 1));
        }
        if (applecount == 3)
        {
            SceneManager.LoadScene(1);
        }

    }

    void ApplyForce(Vector3 direction)
    {
        rb.AddForce(direction * 1, ForceMode.Impulse);
    }
}