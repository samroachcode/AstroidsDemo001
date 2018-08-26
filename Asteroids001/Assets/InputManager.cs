using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody playerCharacter;
    private Vector3 mousePos;

    void Update()
    {
       
    }

    void FixedUpdate()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        playerCharacter.velocity = mousePos * movementSpeed;
        playerCharacter.transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos);
    }
}

