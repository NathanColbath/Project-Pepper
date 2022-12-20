using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    public GameObject target;
    public abstract void Move();
    public abstract void Idle();
    public abstract void Attack();
}
