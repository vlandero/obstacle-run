using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xv = 0.1f;
    [SerializeField] float yv = 0.0f;
    [SerializeField] float zv = 0.1f;
    [SerializeField] float moveSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        xv = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zv = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xv, yv, zv);
    }
}
