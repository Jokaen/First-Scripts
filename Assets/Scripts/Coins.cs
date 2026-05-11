using System;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private int coins;

    [SerializeField] private Text coinsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CoinsTag")
        {
            coins++;
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }
}