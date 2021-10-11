using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {   // moves object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
