using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public float moveSpeed = 4;
    public Vector2 moveDirection;
    public float angleToMouse;
    public bool fireButtonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        moveDirection = new Vector2(moveX, moveY);

    }

    private void Rotate()
    {
        float camDis = Camera.main.transform.position.y - transform.position.y;
        Vector3 mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float angleRad = Mathf.Atan2(mouse.y - transform.position.y,mouse.x - transform.position.x);
        angleToMouse = (180 / Mathf.PI) * angleRad;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();

        fireButtonDown = Input.GetMouseButton(0);
    }
}
