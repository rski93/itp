/*
 * BCreate.cs
 * @author Dariusz Hanuszewicz
 * 15.03.2017
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BCreate : MonoBehaviour {
    public Button ButtonCreate;
    
    public void ButCreate () {
    SceneManager.LoadScene("StartNewGame");
    }
}