using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinToFruit : MonoBehaviour
{
    [SerializeField] public GameObject[] fruits;

    // Start is called before the first frame update
    void Start()
    {
        if (fruits.Length > 0)
        {
            int picked = Random.Range(0, fruits.Length);
            fruits[picked].SetActive(true);
        }
        else
        {
            Debug.LogWarning("No hay frutas para elegir!");
        }
    }
}
