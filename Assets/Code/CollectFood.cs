using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFood : MonoBehaviour
{
    public AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystems.theScore += 1;
        Destroy(gameObject);
    }
}
