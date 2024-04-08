using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroButton : MonoBehaviour
{
    public Hero heroPrefab;

    private void Start()
    {
        UpdateCostText();
    }

    private void UpdateCostText()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            Debug.Log(name + " Has no cost text add it!");
        }
        else
        {
            costText.text = heroPrefab.GetStarCost().ToString();
        }
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<HeroButton>();
        foreach (HeroButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(51, 51, 51, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<SpawnDefender>().SetSelectedHero(heroPrefab);
    }
}
