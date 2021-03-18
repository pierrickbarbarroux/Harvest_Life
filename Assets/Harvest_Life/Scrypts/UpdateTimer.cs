using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpdateTimer : MonoBehaviour
{
    Text text;
    
    void Start()
    {
        text = GetComponent<Text>();
    }

    //Met à jour l'affichage du timer.
    void Update()
    {
        text.text = "Time :  " + Timer.timer;
    }
}
