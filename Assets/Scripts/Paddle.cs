using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
  // configuration parameters
  [SerializeField] float screenWidthInUnits = 16f;
  [SerializeField] float minPaddleX = 1f;
  [SerializeField] float maxPaddleX = 16f - 1f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float mousePositionInUnits = (Input.mousePosition.x / Screen.width) * screenWidthInUnits;
    Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
    paddlePos.x = Mathf.Clamp(mousePositionInUnits, minPaddleX, maxPaddleX);
    transform.position = paddlePos;
  }
}
