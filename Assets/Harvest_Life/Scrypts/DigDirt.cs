using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DigDirt : MonoBehaviour
{

    public int numberOfDigs;
    public int numberOfReduced;
    public float reduceRatio;

    public AudioSource source;
    public AudioClip audio_clip;

    public bool hasBeenDestroyed;

    private int dig;
    private int reduced;

    void Start()
    {
        dig = 0;
        reduced = 0;
        hasBeenDestroyed = false;
    }

    //On diminue la taille de la terre à chaque collision avec les mains.
    //Si la taille a été suffisamment réduite, l'objet "terre" disparait.
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Contact Fingerbone")
        {
            dig += 1;
            if (dig == numberOfDigs)
            {
                source.PlayOneShot(audio_clip, 1.0f);
                Vector3 scale = transform.localScale;
                scale.x = scale.x / reduceRatio; // your new value
                scale.y = scale.y / reduceRatio; // your new value
                scale.z = scale.z / reduceRatio; // your new value
                transform.localScale = scale;
                reduced += 1;
                dig = 0;
            }
            if (reduced >= numberOfReduced)
            {
                Destroy(this.gameObject);
                hasBeenDestroyed = true;
            }

        }
    }
}

