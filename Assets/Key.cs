using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   public GameObject referencDoor;
   public float sizeSpeed;
   private Vector3 initalScale;

   private void Start()
   {
      initalScale = transform.localScale;
   }
   private void FixedUpdate()
   {  
      
   }
}
