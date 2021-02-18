﻿using UnityEngine;

public class UserInput : MonoBehaviour
{
   public Rigidbody2D ballRigidbody2D;
   public Vector2 direction;
   public Vector2 yDirection;

  void Update()
   {
      if (Input.GetKey(KeyCode.RightArrow))
      {
         ballRigidbody2D.AddForce(direction,ForceMode2D.Force);
      }

      if (Input.GetKey(KeyCode.LeftArrow))
      {
         ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
      }

      if (Input.GetKey(KeyCode.UpArrow))
      {
         ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
      }

      if (Input.GetKey(KeyCode.DownArrow))
      {
         ballRigidbody2D.AddForce(-yDirection, ForceMode2D.Force);
      }
   }
}
