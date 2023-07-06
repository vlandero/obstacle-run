using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color originalColor;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("You win!");
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<MeshRenderer>().material.color = originalColor;
        }
    }
}
