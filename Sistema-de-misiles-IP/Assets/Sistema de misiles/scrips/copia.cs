using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copia : MonoBehaviour
{

    public GameObject originalObject;
    public Vector2 offsetPosition;

    // Start is called before the first frame update
    void Start()
    {
        GameObject copyObject = Instantiate(originalObject, transform.position * offsetPosition, Quaternion.identity);
        copyObject.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
