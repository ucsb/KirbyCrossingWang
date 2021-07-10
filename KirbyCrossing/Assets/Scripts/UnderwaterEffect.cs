using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterEffect : MonoBehaviour
{
    public float waterEffectHeight = -0.7f;
    private bool isUnderwater;
    private Color normalColor;
    private Color underwaterColor;

    // Start is called before the first frame update
    void Start()
    {
        normalColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        underwaterColor = new Color(0f, 0.4f, 0.7f, 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        // when player gets in/out of water
        if ((transform.position.y < waterEffectHeight) != isUnderwater)
        {
            isUnderwater = transform.position.y < waterEffectHeight;
            
            if (isUnderwater)
                SetUnderwater();
            if (!isUnderwater) 
                SetNormal();
        }
    }


    void SetNormal()
    {
        RenderSettings.fog = false;

        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = 0.01f;
    }

    void SetUnderwater()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = underwaterColor;
        RenderSettings.fogDensity = 0.1f;

    }

    
}
