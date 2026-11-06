using System;
using UnityEngine;

public abstract class Food : MonoBehaviour
{
    [SerializeField]protected Collider2D collider;
    
    public abstract void Eaten();

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            Eaten();
            pc.Eat();
            Destroy(gameObject);
        }
    }
}
