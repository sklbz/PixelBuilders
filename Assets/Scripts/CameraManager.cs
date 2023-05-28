using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public List<GameObject> objects;
    public GameObject camera;
    int interpolationFramesCount = 100, elapsedFrames = 0;
    int targetX, targetY;

    void Start() {
    }

    private void Update() {
      //Check for mouse click 
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f)) {
                if (raycastHit.transform != null) {
                  //Custom method
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }

      //Lerp the camera Vector
        SlideCamera();
    }

    void DefineCameraMovement(int X, int Y) {
        elapsedFrames = 0;
        targetX = X;
        targetY = Y;
    }

    void SlideCamera() {
        if (elapsedFrames <= interpolationFramesCount) {
            float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;

            camera.transform.position = Vector3.Lerp(camera.transform.position, new Vector3(targetX, targetY, camera.transform.position.z), interpolationRatio);
            elapsedFrames++;
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject) {
        foreach(GameObject obj in objects) {
            if (obj == gameObject) {
                DefineCameraMovement((int)gameObject.transform.position.x, (int)gameObject.transform.position.y);
                return; 
            }
        }
    }
}