using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingFoods : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();

        ScoringSystems.theScore += 1;

        Destroy(gameObject);
    }
}
