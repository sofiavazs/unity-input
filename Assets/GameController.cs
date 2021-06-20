using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
  // Defines an array that stores the list of cameras -> dragged to the list in unity. 
  public GameObject[] gameCameras;

  // Variable that stores the cameras index, starting at 0. 
  private int gameCameraIndex = 0;

    // Start is called before the first frame update
    void Start () {
      FocusOnCamera (gameCameraIndex);
    }

    // Update is called once per frame
    void Update () {
      // condition to listen for mouse input: left = 0 and right = 1
      // Condition to change the camera in ascending order in the array
      if (Input.GetMouseButtonDown(0)) {
        ChangeCamera(1);
      }
      // Condition that changes the camera in descending order in the array
      if (Input.GetMouseButtonDown(1)) {
        ChangeCamera(-1);
      }
    }

    // Method to loop over the array of cameras that receives the index 
    // and disables all the cameras except the one described in the index. 
    void FocusOnCamera (int index) {
      for (int i = 0; i < gameCameras.Length; i++) {
        gameCameras [i].SetActive (i == index);
      }
    }

    // Method that will have the conditions to change the camera. 
    
    void ChangeCamera (int direction) {
    // The argument direction will range between 1 and -1, because it's going to be the delta for index
    // it will increase or decrease the index by a certain value.

      gameCameraIndex += direction;

      // If the game camera index is higher than the array length it means that needs to go back to 0.
      if (gameCameraIndex >= gameCameras.Length) {
        gameCameraIndex = 0;
      }

      // If direction is a negative value (moving back) then we need to check if the 
      // index reaches a negative value 
      if (gameCameraIndex < 0) {
        gameCameraIndex = gameCameras.Length -1; 
      }
      FocusOnCamera(gameCameraIndex);
    }
}
