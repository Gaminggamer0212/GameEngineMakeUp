using System.Collections.Generic;
using UnityEngine;

public class GameManager :  Singleton<GameManager>
{
    [SerializeField]private int currentScore;
    [SerializeField]private List<FoodSpawner> spawners;

    public void AddScore(int score)
    {
        currentScore += score;

        foreach (FoodSpawner spawner in spawners)
        {
            spawner.SpawnFood();
        }
    }
}
