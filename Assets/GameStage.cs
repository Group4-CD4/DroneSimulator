using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStage : MonoBehaviour
{
    public GameObject lockImage;
    public int index;
    private void Start()
    {
        if(index  == PlayerPrefs.GetInt("unlockedLevel"))
        {
            lockImage.SetActive(false);
        }
    }

    public void CompleteLevel(int levelToUnlock)
    {
        if (levelToUnlock > PlayerPrefs.GetInt("unlockedLevel"))
        {
            PlayerPrefs.SetInt("unlockedLevel", levelToUnlock);
        }
    }
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);

    }
}
