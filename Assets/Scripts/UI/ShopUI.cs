using UnityEngine;

public class ShopUI : MonoBehaviour
{
    [SerializeField] private GameObject shopMenu;

    [SerializeField] private int cubePrice;
    [SerializeField] private GameObject cubePrefab;

    [SerializeField] private int spherePrice;
    [SerializeField] private GameObject spherePrefab;

    private Coins playerMoney;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerMoney = player.GetComponent<Coins>();
    }

    public void BuyCube()
    {
        bool successBuy = playerMoney.SpendCoins(cubePrice);

        if (successBuy)
        {
            Instantiate(cubePrefab, new Vector3(Random.Range(-11, -6), 0.5f, Random.Range(-20, -24)), Quaternion.identity);
            Debug.Log("Have your Cube");
        }
    }

    public void BuySphere()
    {
        bool successBuy = playerMoney.SpendCoins(spherePrice);

        if (successBuy)
        {
            Instantiate(spherePrefab, new Vector3(Random.Range(-11, -6), 0.5f, Random.Range(-20, -24)), Quaternion.identity);
            Debug.Log("Have your Sphere");
        }
    }

    public void CloseShopMenu()
    {
        shopMenu.SetActive(false);
    }
}
