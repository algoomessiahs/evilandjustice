using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTimer : MonoBehaviour
{

    public float levelTime = 30f;

    bool levelFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (levelFinished) { return; }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            levelFinished = true;
        }
    }

}
