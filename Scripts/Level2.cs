using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(3);
    }

}
