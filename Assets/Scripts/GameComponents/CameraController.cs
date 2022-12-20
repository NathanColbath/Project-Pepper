using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    private Camera camera = Camera.main;

    public bool shake = false;
    public float range = 1;

    private Vector3 pos;
    void Start()
    {
        camera = Camera.main;
        pos = camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (shake)
        {
            Vector3 randomMove = new Vector3(pos.x + Random.Range(-range, range), pos.y + Random.Range(-range, range), camera.transform.position.z);
            camera.transform.position = Vector3.Lerp(transform.position, randomMove, 0.05f);
        }else
        {
            
            camera.transform.position = Vector3.Lerp(camera.transform.position, pos,0.05f) ;
            
        }
    }
}
