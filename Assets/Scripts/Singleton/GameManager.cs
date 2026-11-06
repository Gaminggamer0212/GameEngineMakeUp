using UnityEngine;

public class GameManager :  Singleton<GameManager>
{
    [SerializeField]private int currentScore;

    public void AddScore(int score)
    {
        currentScore += score;
    }
}
