using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseManager : MonoBehaviour
{    
    public AudioSource audioSource_chicken;
    public AudioClip clip_chicken;    
    public float volume_chicken = 0.5f;
    [SerializeField] private GameObject statUI;
    private bool statIsOpen = false;

    public AudioSource audioSource_switch;
    public AudioClip clip_switch;
    public float volume_switch = 0.5f;
    [SerializeField] private LightSwitch lightSwitch;

    // Update is called once per frame
    void Update()
    {
        OpenStatOnClick();
    }

    private void OpenStatOnClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Player")
                {
                    audioSource_chicken.PlayOneShot(clip_chicken, volume_chicken);
                    if (statIsOpen == false)
                        statUI.SetActive(true);
                    else 
                        statUI.SetActive(false);
                    statIsOpen = !statIsOpen;
                }
                else
                {
                    statUI.SetActive(false);
                }

                if (hit.transform.tag == "LightSwitch")
                {
                    audioSource_switch.PlayOneShot(clip_switch, volume_switch);
                    lightSwitch.PressSwitch();
                }
            }
        }
    }
}
