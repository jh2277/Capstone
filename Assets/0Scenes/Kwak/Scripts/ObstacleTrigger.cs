using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            gameManager.LifeDecrease();
        }
    }
}
