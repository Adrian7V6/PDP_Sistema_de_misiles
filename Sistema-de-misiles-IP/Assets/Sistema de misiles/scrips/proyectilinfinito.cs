using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectilinfinito : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (projectile !=null)
        {
            projectile.velocity = Vector2.right * speed;
        }
    }
}
