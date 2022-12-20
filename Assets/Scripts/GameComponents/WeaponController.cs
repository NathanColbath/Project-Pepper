using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject weaponPrefab;
    public GameObject bulletSpawnPosition;
    private Weapon currentWeapon;

    private Timer timer;
    void Start()
    {
        if(currentWeapon == null)
        {
            ChangeWeapon();
        }
    }

    public void ChangeWeapon()
    {
        currentWeapon = weaponPrefab.GetComponent<Weapon>();
        timer = new Timer(currentWeapon.timeBetweenShots);
    }

    public void ChangeWeapon(GameObject weaponPrefab)
    {
        currentWeapon = weaponPrefab.GetComponent<Weapon>();
    }

    public void Shoot()
    {
        if (timer.IsTriggered())
        {
            //Instantiate
            Debug.Log("Shooting");
            GameObject bullet = Instantiate(currentWeapon.bullet, transform.position, transform.rotation);
            bullet.GetComponent<Bullet>().weaponShotFrom = currentWeapon;
            bullet.GetComponent<SpriteRenderer>().color = Utility.DamageToColor(currentWeapon.damageType);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer.Tick();
    }

    
}
