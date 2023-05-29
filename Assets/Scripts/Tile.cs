using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool isOccupied = false/*, isConquered = false*/;
//    public Color vacantColor, occupiedColor;
    private SpriteRenderer rend;

    void Start() {
        rend = GetComponent<SpriteRenderer>();
    }

/*    void Update() {
        rend.color = (isOccupied) ? occupiedColor : vacantColor;
    }
    */
}