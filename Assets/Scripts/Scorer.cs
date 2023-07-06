using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int numberOfRespawns = 0;
    Vector3 startingPosition = new(105.3f,2.17f,85.87f);
    private void FreezeGame()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Frozen");
    }
    private void UnfreezeGame()
    {
        Time.timeScale = 1f;
        Debug.Log("Game Unfrozen");
    }
    private void OnCollisionEnter(Collision collision)
    { 
        if(collision.collider.tag == "Finish")
        {
            Debug.Log("You win! Number of respawns: " + numberOfRespawns + ". Press R to restart.");
            FreezeGame();
        }
        else
        {
            transform.position = startingPosition;
            numberOfRespawns++;
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startingPosition;
            numberOfRespawns = 0;
            UnfreezeGame();
        }
    }
}
