using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laanzador : MonoBehaviour
{


    public Transform punto_intancia;
    public GameObject misil;
    private float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        tiempo += Time.deltaTime;
        if(tiempo >=5)
        {
            Instantiate(misil, punto_intancia.position, Quaternion.identity);
            tiempo = 0;
        }

    }
}
