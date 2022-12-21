using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ZabiyakaController>().applecount++;
        Object.Destroy(gameObject);
    }
    void Update()
    {

    }
}
