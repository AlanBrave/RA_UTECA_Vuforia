using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Reglas()
    {
        SceneManager.LoadScene("Reglas");
    }

    public void Intro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Salir()
    {
        Debug.Log("Salir....");
        Application.Quit();
    }
}
