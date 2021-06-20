using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour {

  // The target will be the player
  public Transform target;

    void Start () {
    }

    // Update is called once per frame
    // This method will make always a camera follow a player, the player object
    // is dragged into to the chase camera target in Unity
    void Update () {
      transform.LookAt (target);
    }
}
