using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public Text timerText;
    bool TimerStarted = false;
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !TimerStarted)
        {
            StartCoroutine(TimerStarted());
            TimerStarted = true;
        }
    }
    IEnumerator TimerStarted()
    {
        float TimeToDisplay = 0;
        while (true)//this is a loop to check if it is true
        {
           
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);//modulo operation that will returns the remainder, after dividison of one number by another
                                                                 //in this example, modulo is used to return the number of seconds from the total time value that do not make up a whole minute
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            TimeToDisplay += 1;
            yeild return new WaitForSeconds(1);
        }
        
    }
}
