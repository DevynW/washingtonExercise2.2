using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    [SerializeField] Light[] lampLights;
    [SerializeField] Light ceilingLight;
    [SerializeField] Material lampOn;
    [SerializeField] Material lampOff;
    [SerializeField] Material ceilingOn;
    [SerializeField] Material ceilingOff;
    [SerializeField] Renderer[] lampShades;
    [SerializeField] Renderer[] ceilingShade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            if (lampLights[1].enabled)
            {
                
                for (int i = 0; i < lampLights.Length;i++)
                {
                    lampLights[i].enabled = false;
                    lampShades[i].material = lampOff;
                }
            }
            else
            {
                for (int i = 0; i < lampLights.Length; i++)
                {
                    lampLights[i].enabled = true;
                    lampShades[i].material = lampOn;
                }
            }
            //turn of the lamps if they are on, otherwise turn them on
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            if (!ceilingLight.enabled)
            {
                ceilingLight.enabled = true;

                for (int i = 0; i < ceilingShade.Length; i++)
                {
                    ceilingShade[i].material = ceilingOn;
                }

            }
            else
            {
                ceilingLight.enabled = false;

                for (int i = 0; i < ceilingShade.Length; i++)
                {
                    ceilingShade[i].material = ceilingOff;
                }
            }
            //turn on the big light if it is off otherwise turn it on
        }
        
    }
}
