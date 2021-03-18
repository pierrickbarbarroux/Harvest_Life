using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreApple : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    //Met à jour l'affichage du score pour les pommes.
    void Update()
    {
        text.text = "Apple : " + HitScore.score_apple;
    }
}
