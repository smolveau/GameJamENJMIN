using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 120.0f;
    public Text text;

    private bool clock;
    private float mins;
    private float secs;

    void Update()
    {
        if (clock == false)
        {
            clock = true;
            StartCoroutine(Wait());
        }

    }

    IEnumerator Wait()
    {
        timer += 1;
        UpdateTimer();
        yield return new WaitForSeconds(1);
        clock = false;
    }

    void UpdateTimer()
    {
        int min = Mathf.FloorToInt(timer / 60);
        int sec = Mathf.FloorToInt(timer % 60);
        text.text = min.ToString("00") + ":" + sec.ToString("00");
    }
}
