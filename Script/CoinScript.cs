using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private Text coinText;
    private int coin = 0;
    private void Start()
    {
        coinText.text = coin.ToString();
    }
    public void changeCoinBy(int amount)
    {
        coin += amount;
        coinText.GetComponent<Text>().text = coin.ToString();
    }
    public int getCoin()
    {
        return coin;
    }
    // Start is called before the first frame update
}
