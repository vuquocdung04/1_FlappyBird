using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Select : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] gameObjects;
    int choo_Bird;
    private void Start()
    {
        foreach(GameObject go in gameObjects)
        {
            go.SetActive(false);
        }
        SelectBird();
    }

    void SelectBird()
    {
        choo_Bird = PlayerPrefs.GetInt("choo_Bird", 0);
        if (choo_Bird >= 0 && choo_Bird < gameObjects.Length)
        {
            Debug.Log(choo_Bird);
            gameObjects[choo_Bird].SetActive(true);
        }
    }

}
