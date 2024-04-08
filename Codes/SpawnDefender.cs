using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{

    Hero hero;

    private void OnMouseDown()
    {
        AttemptToPlaceHero(GetMouseClickPos());
    }

    public void SetSelectedHero(Hero heroToSelect)
    {
        hero = heroToSelect;
    }

    private void AttemptToPlaceHero(Vector2 gridPos)
    {
        var starDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = hero.GetStarCost();
        if (starDisplay.HaveEnoughStars(defenderCost))
        {
            SpawnNewHero(gridPos);
            starDisplay.SpendStars(defenderCost);
        }
    }

    private Vector2 GetMouseClickPos()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = ToGrid(worldPos);
        return gridPos;
    }

    private Vector2 ToGrid(Vector2 norWorldPos)
    {
        float newx = Mathf.RoundToInt(norWorldPos.x);
        float newy = Mathf.RoundToInt(norWorldPos.y);
        return new Vector2 (newx, newy);
    }

    private void SpawnNewHero(Vector2 roundPos)
    {
        Hero newHero = Instantiate(hero, roundPos, transform.rotation) as Hero;
    }
}
