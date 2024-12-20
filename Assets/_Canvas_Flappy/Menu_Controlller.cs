using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controlller : MonoBehaviour
{



    public void BackHome()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
