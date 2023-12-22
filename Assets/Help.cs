using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Help : MonoBehaviour
{
    public GameObject gameObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != null)
        {
            gameObject.SetActive(true);
        }
    }
}
