using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Help : MonoBehaviour
{
    public GameObject gameObject;
    private GameStage gameStage;
    private Scene currentScene;
    void OnTriggerEnter(Collider other)
    {
        gameStage = new GameStage();
        currentScene = SceneManager.GetActiveScene();
        if (other.gameObject.layer != null)
        {
            if (gameObject.CompareTag("HelpVideo")) {
                gameStage.CompleteLevel(currentScene.buildIndex + 1);
            }
            gameObject.SetActive(true);
        }
    }
}
