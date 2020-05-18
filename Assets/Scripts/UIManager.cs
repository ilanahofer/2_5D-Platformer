using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _coinsText;

    void Start()
    {
        _coinsText.text = "Coins: " + 0;
    }

    public void updateCoinDisplay(int coinScore)
    {
        _coinsText.text = "Coins: " + coinScore.ToString();
    }

}
