using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTarget : MonoBehaviour, IDamageable
{
    public int scoreValue = -5;

    public void TakeDamage()
    {
        ScoreManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
