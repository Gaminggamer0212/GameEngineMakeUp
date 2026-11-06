using UnityEngine;

public class OrangeSpawner : FoodSpawner
{
    public GameObject foodPrefab;
    public override Food SpawnFood()
    {
        GameObject fruitGO = Instantiate(foodPrefab, transform.position, Quaternion.identity);
        return fruitGO.GetComponent<Food>();
    }
}
