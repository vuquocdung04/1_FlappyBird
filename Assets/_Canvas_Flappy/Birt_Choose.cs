using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birt_Choose : MonoBehaviour
{
    public GameObject[] birds;
    public int choose_Bird;


    private void Start()
    {
        choose_Bird = PlayerPrefs.GetInt("choo_Bird",0);
        foreach (var child in birds)
        {
            Debug.Log(child.name);
            child.SetActive(false);
        }
        birds[choose_Bird].SetActive(true);

    }

    private void Update()
    {
        Debug.Log(choose_Bird);
    }
    public void ChangeNext()
    {
        birds[choose_Bird].SetActive(false);
        choose_Bird++;
        if (choose_Bird == birds.Length)
        {
            choose_Bird = 0;
        }

        birds[choose_Bird].SetActive(true);
        PlayerPrefs.SetInt("choo_Bird",choose_Bird);

    }
    public void ChangePrevious()
    {
        birds[choose_Bird].SetActive(false);
        choose_Bird--;
        if(choose_Bird == -1)
        {
            choose_Bird = birds.Length - 1;
        }
        birds[choose_Bird].SetActive(true);

        PlayerPrefs.SetInt("choo_Bird", choose_Bird);
    }
}
