using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    // Start is called before the first frame update

    public DamageType[] damageResistanceTypes;
    public float armorAmount;
    public float damageResistance;
    private float currentArmorAmount;
    void Start()
    {
        currentArmorAmount = armorAmount;

       
    }

    public float ResistancePercentage(float damage)
    {
        return damage * (damageResistance / 100);
    }

    public void TakeDamage(float damage, DamageType damageType)
    {
        for(int index = 0; index < damageResistanceTypes.Length; index++)
        {
            if (damageType == damageResistanceTypes[index])
            {
                damage -= ResistancePercentage(damage);
            }
        }
        currentArmorAmount -= damage;
    }

    public void RepairArmor(float amount)
    {
        currentArmorAmount += amount;
        if (currentArmorAmount > armorAmount)
        {
            currentArmorAmount = armorAmount;
        }
    }

    public bool IsBroken()
    {
        return currentArmorAmount <= 0;
    }

    

}


