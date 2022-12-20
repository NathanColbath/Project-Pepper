using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float moveSpeed;
    public Weapon weaponShotFrom;

    private Rigidbody2D rb;

    private Timer deathTimer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;

        deathTimer = new Timer(5);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.position += new Vector2(rb.transform.right.x, rb.transform.right.y) * moveSpeed * Time.deltaTime;

        deathTimer.Tick();

        if (deathTimer.IsTriggered())
        {
            Destroy(gameObject);
        }
    }
}
