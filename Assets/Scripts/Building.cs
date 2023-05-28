using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int cost;
    public float timeBtwIncreases;
    public float nextIncreaseTime;
    private GameManager gm;

/*     private void Start() {
        gm = FindObjectOfTypes<GameManager>();
    }

    private void Update() {
        if (Time.time > nextIncreaseTime) {
            nextIncreaseTime = Time.time + nextIncreaseTime;
        }
    } */
}
