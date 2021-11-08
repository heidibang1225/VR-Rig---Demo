//this will automatically load my next scene
//atach this script to the object the player will enter to collide

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch1 : MonoBehaviour
{




    private void OnCollisionEnter(Collision other)//change this trigger enter into collision enter
        //get rid of the player
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }
    }


}
