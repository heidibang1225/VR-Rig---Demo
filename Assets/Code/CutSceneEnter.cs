using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneEnter : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject cutsceneCamera;
    void OnTriggerEnter(Collider other)
    {
        cutsceneCamera.SetActive(true);//turning the cutscene camera on
        ThePlayer.SetActive(false);//turning the player's existence off
    }

}
