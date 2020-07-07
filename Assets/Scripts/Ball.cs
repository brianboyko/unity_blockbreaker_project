using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  // config params;
  [SerializeField] Paddle paddle1;
  [SerializeField] float xPush = 2f;
  [SerializeField] float yPush = 15f;
  // state
  Vector2 paddleToBallVector;
  private Boolean hasStarted = false;
  // Start is called before the first frame update
  void Start()
  {
    paddleToBallVector = transform.position - paddle1.transform.position; // hmm, you can subtract vectors?
  }
  void LockBallToPaddle()
  {
    Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
    transform.position = paddlePos + paddleToBallVector;
  }

  // Update is called once per frame
  void LaunchOnMouseClick()
  {
    if (Input.GetMouseButtonDown(0))
    {
      hasStarted = true;
      GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
    }
  }
  void Update()
  {
    if (!hasStarted)
    {
      LockBallToPaddle();
      LaunchOnMouseClick();
    }
  }
}
