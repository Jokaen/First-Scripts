using UnityEngine;

public class Items : MonoBehaviour
{
    [Header("Spear")]
    [SerializeField] private GameObject itemSpearUser;
    [SerializeField] private GameObject itemSpearOnField;

    [Header("Bow")]
    [SerializeField] private GameObject itemBowUser;
    [SerializeField] private GameObject itemBowOnField;

    [Header("Short Sword")]
    [SerializeField] private GameObject itemShortSwordUser;
    [SerializeField] private GameObject itemShortSwordOnField;

    [Header("Shield")]
    [SerializeField] private GameObject itemShieldSwordUser;
    [SerializeField] private GameObject itemShieldSwordOnField;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpearTag"))
        {
            itemSpearUser.SetActive(true);
            itemSpearOnField.SetActive(false);
        }

        if (other.CompareTag("BowTag"))
        {
            itemBowUser.SetActive(true);
            itemBowOnField.SetActive(false);
        }

        if (other.CompareTag("ShortSwordTag"))
        {
            itemShortSwordUser.SetActive(true);
            itemShortSwordOnField.SetActive(false);
        }

        if (other.CompareTag("ShortSwordTag"))
        {
            itemShieldSwordUser.SetActive(true);
            itemShieldSwordOnField.SetActive(false);
        }
    }
}