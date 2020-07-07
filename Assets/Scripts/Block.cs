using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
  public static int blockCount = 0;
  public Block()
  {
    blockCount += 1;
  }
  ~Block()
  {
    if (blockCount != 0)
    {
      blockCount = 0;
      Debug.Log("Deconstructing");
    }
    Destroy(gameObject, 0f);
  }
  private void OnCollisionEnter2D(Collision2D collision)
  {
    blockCount -= 1;
    Debug.Log("Blockcount: " + blockCount);

    if (blockCount == 0)
    {
      Debug.Log("DONE!");
    }
    Destroy(gameObject, 0f);
  }
}
