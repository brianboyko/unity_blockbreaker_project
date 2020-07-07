using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBricks : MonoBehaviour
{
  [SerializeField] GameObject block;

  // Start is called before the first frame update
  void Start()
  {
    int startX = 2;
    int endX = 15;
    int startY = 6;
    int endY = 11;
    for (int i = startX; i < endX; i++)
    {
      for (int j = startY; j < endY; j++)
      {
        GameObject currentBlock = Instantiate(block);
        Vector2 blockPos = new Vector2(currentBlock.transform.position.x, currentBlock.transform.position.y);
        Vector2 delta = new Vector2(i, j);
        currentBlock.transform.position = blockPos + delta;
      }

      //   currentObject.transform.position = //Whatever position
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
