using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public PopUp[] popUps;
    private int popUpIndex;
    
    void Update() {
        for (int i = 0; i < popUps.Length; i++) {
            if (i == popUpIndex) {
                popUps[i].obj.SetActive(true);
            } else {
                popUps[i].obj.SetActive(false);
            }
        }
        if(popUpIndex == popUps.Length - 1) {
            if(Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    public void NextPopUp() {
        popUpIndex++;
    }
}
