using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySound : MonoBehaviour
{
    private void Update()
    {
        Destroy(FindObjectOfType<PauseAudio>().audioSource);
    }
}
