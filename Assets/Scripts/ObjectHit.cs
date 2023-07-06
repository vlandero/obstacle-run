using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color originalColor;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<MeshRenderer>().material.color = originalColor;
            gameObject.tag = "Untagged";
        }
    }
}
