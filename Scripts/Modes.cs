using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modes : MonoBehaviour
{
    // Start is called before the first frame update
    public void HCMode()
    {
        SceneManager.LoadScene("AITerrain");
    }

    public void MPMode()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Back()
    {
        SceneManager.LoadScene("Login");
    }
}
