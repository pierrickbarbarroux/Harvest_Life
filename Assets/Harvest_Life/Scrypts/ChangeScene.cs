using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public GameObject victory;
    public GameObject defeat;

    Scene act_scene;
    int nb_scenes;

    // Start is called before the first frame update
    void Start()
    {
        //On actualise la scène actuelle à chaque changement de scène. 
        //Chaque changement de scène est suivi d'un feedback.
        act_scene = SceneManager.GetActiveScene();
        nb_scenes = SceneManager.sceneCountInBuildSettings;
        source.PlayOneShot(clip, 1.0f);
    }

    //On charge la scène suivante (dans l'ordre du build).
    public void next_scene()
    {
        if (act_scene.buildIndex == (nb_scenes - 1))
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(act_scene.buildIndex + 1);
        }
    }

    //On charge la scène précédente (dans l'ordre du build)
    public void previous_scene()
    {
        if (act_scene.buildIndex == 0)
        {
            SceneManager.LoadScene(nb_scenes - 1);
        }
        else
        {
            SceneManager.LoadScene(act_scene.buildIndex - 1);
        }
    }

    //On quitte l'application.
    public void leave()
    {
        Application.Quit();
    }

    //On réinitialise le jeu puis on retourne au menu principale
    public void go_main_menu()
    {
        Timer.timer = 60.0f;
        HitScore.score_apple = 6;
        HitScore.score_carrot = 4;
        victory.SetActive(false);
        defeat.SetActive(false);
        SceneManager.LoadScene(0);
    }

}
