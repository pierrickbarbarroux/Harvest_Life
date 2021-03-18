using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpdateScoreCarrot : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    //Met à jour l'affichage du score pour les carottes.
    void Update()
    {
        text.text = "Carrot : " + HitScore.score_carrot;
    }
}
