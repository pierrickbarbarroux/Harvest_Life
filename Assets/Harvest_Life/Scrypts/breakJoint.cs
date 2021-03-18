using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakJoint : MonoBehaviour
{
    public AudioClip audio_destroy;
    public AudioSource source;

    //Destruction de l'objet (joint) qui permet de tenir les pommes et les carottes en place avant qu'elles
    //ne soient arrachées
    private void OnJointBreak(float breakForce)
    {
        source.PlayOneShot(audio_destroy, 1.0f);
        Destroy(this);
    }

}
