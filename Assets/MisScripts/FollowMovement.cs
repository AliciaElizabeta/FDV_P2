using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float rotationSpeed;

    public Transform goal;
    void Start()
    {
        speed = 1f;
        rotationSpeed = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.position != transform.position) {
            Vector3 diferencia = goal.position - transform.position;
            transform.LookAt(goal.position);       
            transform.Translate(diferencia.normalized * speed*Time.deltaTime, Space.World);
            Debug.DrawRay(this.transform.position, diferencia, Color.red);
        }
    }
}
