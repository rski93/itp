/*
 *15/04/2017
 *Revision 6
 *LockLevel.cs
 *@author Carl Moylan 15014355
 *@author Sujit Horakeri
 *Lock Levels tutorial available at http://www.thegamecontriver.com/2014/09/create-level-lock-unlock-system-unity-46.html 
 *NOTE... I tried several versions of this script but could not get any to work as expected.
*/

using UnityEngine;
using System.Collections;

// With a Main Menu, this LockLevels script can be attached to the New Game button so that it deletes all the PlayerPrefs keys. To give the option of Continue this script would not be used as it deletes all the PlayerPrefs keys. 
 
public class LockLevel : MonoBehaviour { 
  
 public static int worlds = 1; //number of worlds, there is only 1 world in this game
 public static int levels = 2; //number of levels, only 2 levels have been created so far
  
 private int worldIndex;   
 private int levelIndex;   
  
  
 void  Start (){
  PlayerPrefs.DeleteAll(); //erase data on start of the game.
  LockLevels();   //call function LockLevels
 }
  
 //function to lock the levels
 void  LockLevels (){
  //loop thorugh all the levels of the world
  for (int i = 0; i < worlds; i++){
   for (int j = 1; j < levels; j++){
    worldIndex  = (i+1);
    levelIndex  = (j+1);
    //create a PlayerPrefs of that particular level and world and set it's to 0, if no key of that name exists
    if(!PlayerPrefs.HasKey("level"+worldIndex.ToString() +":" +levelIndex.ToString())){
     PlayerPrefs.SetInt("level"+worldIndex.ToString() +":" +levelIndex.ToString(),0);//updates the player preferences to level 0 if no key already exists
    }
     
   }
  }
   
 }
}