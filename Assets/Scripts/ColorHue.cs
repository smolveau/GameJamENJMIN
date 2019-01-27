using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorHue : MonoBehaviour
{
    Image m_image;

    // Start is called before the first frame update
    void Start()
    {
        m_image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        m_image.color = Color.HSVToRGB(Mathf.PingPong(Time.time / 2, 1) , 1, 1);
    }
}
