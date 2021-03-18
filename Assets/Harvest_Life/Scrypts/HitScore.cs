using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScore : MonoBehaviour
{
    //public BoxCollider end_of_basket_collider;
    //public Collider panier;
    public static int score_apple =6;
    public static int score_carrot = 4;
    public GameObject effet_visuel;

    public float f;
    public AudioSource source;
    public AudioClip collected;

    //Gère le score lorsqu'une pomme ou une carotte est mise dans le panier.
    void OnTriggerEnter(Collider collider)
    {
        //S'il s'agit d'une pomme, on diminue le nombre de pomme de 1 et on détruit l'objet pomme
        //Feedback visuel
        //Feedback audio
        if (collider.tag == "DisappearApple")
        {
            source.PlayOneShot(collected, 1.0f);
            if (score_apple > 0)
            {
                score_apple -= 1;
            }
            Destroy(this.gameObject);
            Vector3 vec3 = collider.transform.position;
            vec3.y += f;
            GameObject smiley = Instantiate(effet_visuel, vec3, Quaternion.identity);
            smiley.GetComponent<ParticleSystem>().Play();
            
        }

        //S'il s'agit d'une carotte, on diminue le nombre de carotte de 1 et on détruit l'objet carotte
        //Feedback visuel
        //Feedback audio
        if (collider.tag == "DisappearCarrot")
        {
            source.PlayOneShot(collected, 1.0f);
            if (score_carrot > 0)
            {
                score_carrot -= 1;
            }
            Destroy(this.gameObject);
            Vector3 vec3 = collider.transform.position;
            vec3.y += f;
            GameObject smiley = Instantiate(effet_visuel, vec3, Quaternion.identity);
            smiley.GetComponent<ParticleSystem>().Play();
        }


    }
}
