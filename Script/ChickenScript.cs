using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenScript : MonoBehaviour
{
    #region StatsBar
    [SerializeField] private BarController healthBar;
    [SerializeField] private BarController hungerBar;
    [SerializeField] private BarController fatigueBar;

    private int maxHealth = 100;
    private int maxHunger = 100;
    private int maxfatigue = 100;
    #endregion

    private void Start()
    {
        // Initialize (or else it won't work)
        healthBar.MaxHealth = maxHealth;
        healthBar.CurrentValue = maxHealth;
        hungerBar.MaxHealth = maxHunger;
        hungerBar.CurrentValue = maxHunger;
        fatigueBar.MaxHealth = maxfatigue;
        fatigueBar.CurrentValue = maxfatigue;
    }
}
