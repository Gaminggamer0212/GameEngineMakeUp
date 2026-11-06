using UnityEngine;

public class GameManager :  Singleton<GameManager>
{
    private int currentScore;

    public void AddScore(int score)
    {
        currentScore += score;
    }
}
