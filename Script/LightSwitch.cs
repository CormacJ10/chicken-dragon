using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] private Light myLight;

    public void PressSwitch()
    {
        myLight.enabled = !myLight.enabled;
    }
}
