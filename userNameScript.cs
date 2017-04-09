 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class userNameScript : MonoBehaviour {
 
     public string userName;
     public GameObject inputField;
 
     public void OnEntry()
     {
         userName = inputField.GetComponent<InputField>().text;
         Debug.Log ("your username is " + userName);
     }
 }