using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMesh : MonoBehaviour
{
    public MeshCollider meshToActivate;

    public GameObject dirtPile;

    // Update is called once per frame
    void Update()
    {
        if (!dirtPile && !meshToActivate.enabled)
        {
            meshToActivate.enabled = true;

        }
    }
}
