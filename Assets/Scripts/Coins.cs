using System;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private int coins;

    [SerializeField] private Text coinsText;


    public void Start()
    {
        UpdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CoinsTag")
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }

    public bool SpendCoins(int amount)
    {
        if (coins < amount)
        {
            Debug.Log("Not enough money");
            return false;
        }

        coins -= amount;
        UpdateUI();

        return true;
    }

    private void UpdateUI()
    {
        coinsText.text = coins.ToString();
    }
}