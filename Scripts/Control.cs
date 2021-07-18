using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void CambiarNivel(int nivel)
    {
        if (nivel==0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene("Level "+nivel);
        }
    }
    public void CambiarNivel2(int nivel)
    {
        if (nivel == 2)
        {
            SceneManager.LoadScene("Options");
        }
    }
    public void CambiarNivel3(int nivel)
    {
        if (nivel == 3)
        {
            SceneManager.LoadScene("Lvls");
        }
    }
}
