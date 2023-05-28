using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Tile;
    public Transform parent;

    void Start()
    {
        Create(-5,-2, 5, 2);
    }

    void Create(int fromX, int fromY, int toX, int toY) {
        for(int i = fromX; i <= toX; i++) {
            for(int j = fromY; j <= toY; j++) {
                if(j != 0 || i != 0) {
                    Instantiate(Tile, new Vector2(i * 2, j * 2), Quaternion.identity, parent);
                }
            }
        }
    }
}