using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoidScript : MonoBehaviour
{
    public Transform playerPrefab;

    void Update()
    {
        Debug.Log(playerPrefab.position.y);
        if(playerPrefab.position.y < -10.0)
        {
            Debug.Log("Respawn");
            SceneManager.LoadScene("Game");
        }
    }
}
