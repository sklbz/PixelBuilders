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

   void Update() {
      goldDisplay.text = gold.ToString(); // Display the gold amount 
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
