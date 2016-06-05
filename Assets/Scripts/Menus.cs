using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void CallSingleplayerScene(){
		PlayerPrefs.SetInt("gameplay", 1);
		SceneManager.LoadScene(1);
	}
	public void CallMultiplayerScene(){
		PlayerPrefs.SetInt("gameplay", 2);
		SceneManager.LoadScene(1);
	}
	public void CallSettings(){
		
	}
	public void CallQuit(){
		
	}
}
