using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerCylinder : MonoBehaviour
{
    int counterPoints;
    void Start()
    {
        counterPoints = 0;
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Renderer render = other.GetComponent<Renderer>();
        if (other.gameObject.tag == "Target" && render.material.color != Color.red)
        {
            AddPoints();
        }
            
        render.material.color = Color.red;
        Debug.Log("Collision w/ " + other.gameObject.name);
    }

    void AddPoints()
    {
        counterPoints++;
        Debug.Log("Actual Points : " + counterPoints);
    }
}
