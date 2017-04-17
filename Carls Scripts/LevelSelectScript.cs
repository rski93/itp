using UnityEngine;
using System.Collections;
 
public class LevelSelectScript : MonoBehaviour {
 
 private int worldIndex;   
 private int levelIndex;   
 
 void  Start (){
  //loop thorugh all the worlds, Carl
  for(int i = 1; i <= LockLevel.worlds; i++){
   if(Application.loadedLevelName == "World"+i){
    worldIndex = i;
    CheckLockedLevels(); 
   }
  }
 }
 
 //Level to load on button click. Will be used for Level button click event 
 public void Selectlevel(string worldLevel){
  Application.LoadLevel("Level"+worldLevel); //load the level
 }
 
 //could be used to navigate to the Main Menu on clicking escape when in World1 scene, Carl
 /*public void  Update (){
  if (Input.GetKeyDown(KeyCode.Escape) ){
   Application.LoadLevel("MainMenu");
  }   
 }*/
  
 //function to check for the levels locked, Carl
 void  CheckLockedLevels (){
  //loop through the levels of a particular world, in this game there is only 1 world, Carl
  for(int j = 1; j < LockLevel.levels; j++){
   levelIndex = (j+1);
   if((PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString()))==1){
    GameObject.Find("LockedLevel"+(j+1)).active = false;
    Debug.Log ("Unlocked");
   }
  }
 }
}