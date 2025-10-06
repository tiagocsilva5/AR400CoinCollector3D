using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI CoinText;
    public float rotationSpeed = 100f; // degrees per second

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++;
            CoinText.text = "Coins: " + Coin.ToString() + "/10";
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }
}
