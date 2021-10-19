using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private BarController healthBar;
    [SerializeField] private BarController hungerBar;
    [SerializeField] private BarController fatigueBar;

    private void Start()
    {
        healthBar.MaxHealth = 100;
        healthBar.CurrentValue = 100;
        hungerBar.MaxHealth = 100;
        hungerBar.CurrentValue = 100;
        fatigueBar.MaxHealth = 100;
        fatigueBar.CurrentValue = 100;
    }
    private void Update()
    {
        if (Input.GetKeyDown("a")){
            healthBar.ChangeBy(-10);
            Debug.Log("Key Pressed");
        }
        if (Input.GetKeyDown("f"))
        {
            healthBar.ChangeBy(10);
        }
        if (Input.GetKeyDown("s")){
            hungerBar.ChangeBy(-10);
        }
        if (Input.GetKeyDown("d")){
            fatigueBar.ChangeBy(-10);
        }
        Debug.Log(healthBar.CurrentValue);
    }

}

