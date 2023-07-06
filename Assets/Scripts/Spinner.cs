using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 200;
    [SerializeField] float zAngle = 0;
    // Update is called once per frame
    void Update()
    {
        var angleToRotateX = xAngle * Time.deltaTime;
        var angleToRotateY = yAngle * Time.deltaTime;
        var angleToRotateZ = zAngle * Time.deltaTime;
        transform.Rotate(angleToRotateX, angleToRotateY, angleToRotateZ);
    }
}
