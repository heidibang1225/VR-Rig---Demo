using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
   // public float timeValue = 90;
    public Text timerText;
    bool timerStarted = false;
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !timerStarted)//if the player touches this object
        {
            StartCoroutine(TimerStarted());//start the timer after a mini pause
            timerStarted = true;//turn the timer on to start because it was false before
        }
    }
    IEnumerator TimerStarted()
    {
        float TimeToDisplay = 90;
        while (true)//this is a loop to check if it is true
        {
           
            //to display the time correctly, both minutes and seconds need to be calculted individually from the raw time value 
            float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
            float seconds = Mathf.FloorToInt(TimeToDisplay % 60);//modulo operation that will returns the remainder, after dividison of one number by another
                                                                 //in this example, modulo is used to return the number of seconds from the total time value that do not make up a whole minute
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            //{0:00} formating option with zerops as placeholders       this is variable "1" seconds
            //{1:00} this is variable "2" minutes
            //TimeToDisplay += 1;//this is the same thing to TimeToDisplay++
            TimeToDisplay -= 1;
            yield return new WaitForSeconds(1);
        }
        
    }
}
 