using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStage : MonoBehaviour
{
    public void TrainingScreen()
    {
        SceneManager.LoadScene(2);
    }
    public void Screen1()
    {
        SceneManager.LoadScene(3);
    }
    public void Screen2()
    {
        SceneManager.LoadScene(4);
    }
    public void Screen3()
    {
        SceneManager.LoadScene(5);
    }
}
