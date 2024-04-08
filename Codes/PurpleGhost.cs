using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleGhost : MonoBehaviour
{
    public GameObject whatToFire;
    public GameObject firepos;

    public void Fire()
    {
        GameObject Lazer = Instantiate(whatToFire);
        Lazer.transform.position = firepos.transform.position;
    }
}
