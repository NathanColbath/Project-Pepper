using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float maxHP;
    private float currentHP;


    void Start()
    {
        currentHP = maxHP;
    }

    public float GetHP()
    {
        return currentHP;
    }

    public void ResetHP()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
    }

    public void Heal(float healAmount)
    {
        currentHP += healAmount;
        if(currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }

    public bool IsDead()
    {
        return currentHP <= 0;
    }
}
