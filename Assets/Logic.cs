using DroneController.Physics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    int durability = 100;
    public Text textDurability;
    int progress = 0;
    public Text textProgress;
    public GameObject tryAgain;
    public GameObject finish;
    public void ReducedDurability()
    {

        durability -= 1;
        textDurability.text = durability.ToString();
        Check();
    }

    public void ThroughSuccess()
    {
        progress += 1;
        textProgress.text = progress.ToString()+"/5";
        Check();
    }
    public void Check()
    {
        if(progress == 5)
        {
            finish.SetActive(true);
        }
        if(durability == 0)
        {
            tryAgain.SetActive(true);
        }
    }
}
