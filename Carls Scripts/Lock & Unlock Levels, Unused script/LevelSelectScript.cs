/*15/04/2017
 *LevelSelectScript.cs
 *@author Carl Moylan 15014355
 *@author Sujit Horakeri 
 *Tutorial available at http://www.thegamecontriver.com/2014/09/create-level-lock-unlock-system-unity-46.html 
 */ 

using UnityEngine;// 'using' imports the library needed
using System.Collections;
using UnityEngine.SceneManagement;

//This script is attached to the main camera and linked to the onClick event for each level button with the string 1:1 for level 1 button, 1:2 for level 2 button etc
 
public class LevelSelectScript : MonoBehaviour {
 
 private int worldIndex;   
 private int levelIndex;   
 
 void  Start (){
  //loop thorugh all the worlds
  for(int i = 1; i <= LockLevel.worlds; i++){
   if(SceneManager.LoadSceneName == "World"+i){
    worldIndex = i;
    CheckLockedLevels(); 
   }
  }
 }
 
 //Level to load on button click. Will be used for Level button click event 
 public void Selectlevel(string worldLevel){
  SceneManager.LoadScene("Level"+worldLevel); //load the level
 }
 
 //this could be used to navigate to the Main Menu on clicking escape when in World1 scene
 /*public void  Update (){
  if (Input.GetKeyDown(KeyCode.Escape) ){
   SceneManager.LoadScene("MainMenu");
  }   
 }*/
  
 //function to check for the levels that are locked
 void  CheckLockedLevels (){
  //loop through the levels of a particular world, in this game there is only 1 world
  for(int j = 1; j < LockLevel.levels; j++){
   levelIndex = (j+1);
   if((PlayerPrefs.GetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString()))==1){
    GameObject.Find("LockedLevel"+(j+1)).active = false;
    Debug.Log ("Unlocked");
   }
  }
 }
}