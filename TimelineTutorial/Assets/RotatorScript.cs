using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float x = 50f;
    public float y = 0f;
    public float z = 0f;

    public float speed = 5f;
    void Update()
    {
        transform.Rotate(new Vector3(x,y,z) * speed * Time.deltaTime);
    }
}
