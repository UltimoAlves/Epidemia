using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void CallSingleplayerScene(){
		SceneManager.LoadScene(1);
	}
	public void CallMultiplayerScene(){
		SceneManager.LoadScene(1);
	}
	public void CallSettings(){
		
	}
	public void CallQuit(){
		
	}
}
