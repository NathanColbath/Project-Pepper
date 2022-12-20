using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;
    public float timeBetweenShots;
    public DamageType damageType;
    public GameObject bullet;

    public void Start()
    {
        //timeBetweenShots = 1 - Ti
    }
}
