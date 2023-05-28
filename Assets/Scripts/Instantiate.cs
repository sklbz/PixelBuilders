using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject Tile;
    public Transform parent;

    void Start()
    {
        Instantiate(Tile, new Vector2(2,0), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(0,2), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(-2,0), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(0,-2), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(2,-2), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(-2,2), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(2,2), Quaternion.identity, parent);
        Instantiate(Tile, new Vector2(-2,-2), Quaternion.identity, parent);
    }
}