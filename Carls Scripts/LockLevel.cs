using UnityEngine;
using System.Collections;
 
public class LockLevel : MonoBehaviour {
  
  
 public static int worlds = 1; //number of worlds, there is only 1 world in this game, Carl
 public static int levels = 2; //number of levels, only 2 levels have been created so far, Carl
  
 private int worldIndex;   
 private int levelIndex;   
  
  
 void  Start (){
  PlayerPrefs.DeleteAll(); //erase data on start of the game, Carl
  LockLevels();   //call function LockLevels
 }
  
 //function to lock the levels
 void  LockLevels (){
  //loop thorugh all the levels of the world, Carl
  for (int i = 0; i < worlds; i++){
   for (int j = 1; j < levels; j++){
    worldIndex  = (i+1);
    levelIndex  = (j+1);
    //create a PlayerPrefs of that particular level and world and set it's to 0, if no key of that name exists
    if(!PlayerPrefs.HasKey("level"+worldIndex.ToString() +":" +levelIndex.ToString())){
     PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString(),0);//updates the player preferences to level 0 if no key already exists, Carl
    }
     
   }
  }
   
 }
}