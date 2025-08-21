using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTarget : MonoBehaviour, IDamageable
{
    public int scoreValue = 10;
    public void TakeDamage()
    {
        ScoreManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
