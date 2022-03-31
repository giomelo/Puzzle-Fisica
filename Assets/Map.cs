using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    private Vector3 _mousePosition;
    private readonly float _speed = 15f;
    [SerializeField]
    private Rigidbody rb;
    private void Update()
    {
        if(Controlador.controlador.canRotate)
        {
            if (Camera.main != null) _mousePosition = Camera.main.ViewportToWorldPoint(Input.mousePosition);
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            ProcessInput(horizontal, vertical);
        }   
        
    }

    private void ProcessInput(float horizontal, float vertical)
    {
        transform.Rotate(new Vector3(0, 1, 0), _speed * horizontal * Time.deltaTime);
        transform.Rotate(new Vector3(1, 0 ,0), _speed * vertical* Time.deltaTime);

       // if (vertical == 0 || horizontal == 0) return;
        
       
        

    }
}
