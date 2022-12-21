using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform player;
    Vector3 delta;

    private void Start()
    {
        delta = transform.position - player.position;
    }

    private void Update()
    {
        transform.position = player.position + delta;
    }
}