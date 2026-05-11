using Unity.VisualScripting;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    [SerializeField] private GameObject[] itemsToNextScene;

    private void Awake()
    {
        foreach (var item in itemsToNextScene)
        {
            DontDestroyOnLoad(item);
        }
    }
}