using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [Header("Gameplay Components")]
    public GameObject armor;
    public GameObject hp;

    [Header("Core Controller Components")]
    public Inputs input;
    public Rigidbody2D body;
    public CollisionController collisionController;
    public WeaponController weaponController;


    private Armor currentArmor;
    private HP currentHp;

    private CameraController cameraController;


    // Start is called before the first frame update
    void Start()
    {
        InitComponents();
    }


    private void InitComponents()
    {
        input = GetComponent<Inputs>();
        body = GetComponent<Rigidbody2D>();
        collisionController = GetComponent<CollisionController>();
        currentArmor = armor.GetComponent<Armor>();
        currentHp = hp.GetComponent<HP>();
        weaponController = GetComponent<WeaponController>();
        cameraController = Camera.main.GetComponent<CameraController>();

        collisionController.playerArmor = currentArmor;
        collisionController.playerHP = currentHp;

        GetComponent<SpriteRenderer>().color = Utility.DamageToColor(currentArmor.damageResistanceTypes[0]);
    }

    // Update is called once per frame
    void Update()
    {
        body.position += input.moveDirection;
        //body.rotation = Mathf.Lerp(body.rotation,input.angleToMouse,0.005f);
        body.rotation = input.angleToMouse;
        if (input.fireButtonDown)
        {
            weaponController.Shoot();
            cameraController.shake = true;
        }
        else
        {
            cameraController.shake = false;
        }
    }

    
}
