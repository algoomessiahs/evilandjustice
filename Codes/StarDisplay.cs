using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarDisplay : MonoBehaviour
{
    public int stars = 100;

    TextMeshProUGUI starText;

    private void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int addAmount)
    {
        stars += addAmount;
        UpdateDisplay();
    }

    public void SpendStars(int subAmount)
    {
        if (stars >= subAmount)
        {
            stars -= subAmount;
            UpdateDisplay();
        }
    }

}
