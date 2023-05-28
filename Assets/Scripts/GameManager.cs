using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public Text goldDisplay;
    private Building buildingToPlace;
    public GameObject grid;
    public CustomCursor customCursor;
    public Tile[] tiles;
    public Text OK;
/* 
    void Update()
    {
      goldDisplay.text = gold.ToString(); // Display the gold amount 

      if (Input.GetMouseButtonDown(0) && buildingToPlace != null) {
         Tile nearestTile = null;
         float nearestDistance = float.MaxValue;
         foreach(Tile tile in tiles) {
            float dist = Vector2.Distance(tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (dist < nearestDistance) {
               nearestDistance = dist;
               nearestTile = tile;
            }
         }
         if (nearestTile.isOccupied == false) {
            Instantiate(buildingToPlace, nearestTile.transform.position, Quaternion.identity);
            buildingToPlace = null;
            nearestTile.isOccupied = true;
            grid.SetActive(false);
            customCursor.GameObject.SetActive(false);
            Cursor.SetActive(true);
         }
      }
    }

    public void BuyBuilding(Building building){
       if (gold >= building.cost) {
        customCursor.GameObject.SetActive(true);
        customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
        Cursor.visible = false;
        
        gold -= building.cost;
        buildingToPlace = building;
        grid.SetActive(true);
       } 
    } */
}
