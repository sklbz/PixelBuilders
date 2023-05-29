using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public int gold;
   public Text goldDisplay;
   private Building buildingToPlace;
   public CustomCursor customCursor;
   public Tile[] tiles;
   public Transform playArea;
   public Grid grid;

   void Update() {
      goldDisplay.text = gold.ToString(); // Display the gold amount 

      if(Input.GetMouseButtonDown(0) && buildingToPlace != null) {
         Tile nearestTile = null;
         float shortestDistance = float.MaxValue;
         foreach(Tile tile in tiles) {
            float dist = Vector2.Distance(tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if(dist < shortestDistance) {
               shortestDistance = dist;
               nearestTile = tile;
            }
         }
         if(!nearestTile.isOccupied) {
            Instantiate(buildingToPlace, nearestTile.transform.position, Quaternion.identity, playArea);
            buildingToPlace = null;
            nearestTile.isOccupied = true;
            customCursor.GameObject.SetActive(false);
            Cursor.visible = true;
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
      } 
   }
}
