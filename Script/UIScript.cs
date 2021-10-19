using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Slider healthSlider;
    public Slider hungerSlider;

    [SerializeField] public GameObject leftCanvas;
    [SerializeField] public GameObject rightCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealth(int health){
        healthSlider.value = health;
    }

    public void SetMaxHealth(int health){
        healthSlider.maxValue=health;
    }

    public void SetHunger(int hunger){
        hungerSlider.value = hunger;
    }

    public void SetMaxHunger(int hunger){
        hungerSlider.maxValue=hunger;
    }
}
