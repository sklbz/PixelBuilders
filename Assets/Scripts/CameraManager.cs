using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject mainCamera;
    Vector3 targetPos;
    bool isCameraMovementDefined = false;
    int interpolationFramesCount = 100, elapsedFrames;

    void Update() {
      MoveCamera();
    }

    public void CameraFocus(GameObject building) {
      targetPos = new Vector3(building.transform.position.x, building.transform.position.y, -1);
      elapsedFrames = 0;
      isCameraMovementDefined = true;
    }

    void MoveCamera() {
        if(isCameraMovementDefined && elapsedFrames <= interpolationFramesCount) {
            float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPos, interpolationRatio);
            elapsedFrames++;
        }
    }
}