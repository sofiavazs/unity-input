using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    // Start is called before the first frame update
    void Start () {
    }


    // Update is called once per frame
    void Update () {
      if (Input.GetKeyDown("space")) {
        Debug.Log("jump");
      }
      if (Input.GetKeyDown("left")) {
        Debug.Log("left");
      }
      if (Input.GetKeyDown("right")) {
        Debug.Log("right");
      }
    }
}
