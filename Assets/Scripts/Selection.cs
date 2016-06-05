using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Selection : MonoBehaviour {
	// Use this for initialization
	public GameObject[] personagens;
	public GameObject personagemAtual;
	public int aux;
	public int cont;
	public int np;


	void Start () {

		personagemAtual = Instantiate(personagens[0], new Vector2(0f,0f), personagens[0].transform.rotation) as GameObject;	

	}


	public void Seleciona(){

		if(cont==30 && PlayerPrefs.GetInt("gameplay")==1){
			SceneManager.LoadScene(2);
		}
		else if(cont==30 && PlayerPrefs.GetInt("gameplay")==2 && np==2){
			SceneManager.LoadScene(2);
		}


		if(PlayerPrefs.GetInt("gameplay")==1){
			PlayerPrefs.SetInt("personagemAtual", aux);
			SceneManager.LoadScene(2);
		} else {
			np++;
			if(np == 1){
				PlayerPrefs.SetInt("personagemAtual", aux);
			}
			else if (np == 2){
				PlayerPrefs.SetInt("personagemAtual2", aux);
				SceneManager.LoadScene(2);
			}
		}

	}


	public void Instancia(int n){
		Destroy(personagemAtual);
		personagemAtual = Instantiate(personagens[n], new Vector2(0f,0f), personagens[n].transform.rotation) as GameObject;	
	}

	public void LeftArrow (){
		if(aux==0){

			aux = personagens.Length-1;
		}
		else {

			aux--;
		}
		Instancia(aux);
	}

	public void RigthArrow (){
		if(aux == personagens.Length-1){
			aux = 0;
		}
		else {
			aux++;
		}
		Instancia(aux);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
