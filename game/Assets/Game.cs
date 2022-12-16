using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    player playerObject;

    GameObject keys;
    private void Update()
    {
        if (playerObject.KeysFound() == 5)
        {
            Debug.Log("Game over!");
        }
    }
}