using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    float speedIncrease = 1;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        rotationSpeed = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            speedIncrease *= 2;
        }

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime * speedIncrease;
        rotation *= Time.deltaTime;
        transform.Translate(0,0,translation);
        transform.Rotate(0,rotation,0);

    }
}
