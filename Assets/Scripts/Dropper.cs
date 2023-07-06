using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5.0f;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    Vector3 originalPosition;
    float restartTime;
    // Start is called before the first frame update
    void Start()
    {
        restartTime = Time.time;
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - restartTime > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            // reset the position and the timer
            transform.position = originalPosition;
            renderer.enabled = false;
            rigidbody.useGravity = false;
            restartTime = Time.time;
        }
    }
}
