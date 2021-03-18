using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory_Defeat : MonoBehaviour
{
    public GameObject victory;
    public GameObject defeat;

    public AudioClip clip_victory;
    public AudioClip clip_lose;
    public AudioSource source;
    int i;

    //Fait apparaitre les messages de victoire et de défaite.
    void Update()
    {

        //Conditions de victoires
        if (HitScore.score_apple == 0 && HitScore.score_carrot == 0 && Timer.timer>0.0f)
        {
            victory.SetActive(true);
            source.PlayOneShot(clip_victory, 1.0f);
            i = 1;
        }
        else
        {
            //Conditions de défaite
            if (Timer.timer == 0.0f && i!=1)
            {
                source.PlayOneShot(clip_lose, 1.0f);
                defeat.SetActive(true);
            }
        }

    }
}
