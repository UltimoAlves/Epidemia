using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Selection : MonoBehaviour {

	// Use this for initialization
	public GameObject[] personagens;
	public GameObject personagemAtual;
	public GameObject[] mapas;
	public GameObject mapaAtual;
	public int auxP;
	public int auxM;
	public int np;


	void Start () {
		auxM =0;
		auxP =0;
		np =0;
		//mapaAtual = Instantiate(mapas[0], new Vector2(0f,0f), mapas[0].transform.rotation) as GameObject;	
		personagemAtual = Instantiate(personagens[0], gameObject.transform.position, personagens[0].transform.rotation) as GameObject;	
	

	}


	public void Seleciona(){

		if(PlayerPrefs.GetInt("gameplay")==1){
			personagemAtual.GetComponent<Animator>().SetBool("selecionado", true);
			PlayerPrefs.SetInt("personagemAtual", auxP);
			SceneManager.LoadScene(2);
	
		} else {
			np++;
			if(np == 1){
				personagemAtual.GetComponent<Animator>().SetBool("selecionado", true);
				PlayerPrefs.SetInt("personagemAtual", auxP);
				SceneManager.LoadScene(2);
			}
			else if (np == 2){
				personagemAtual.GetComponent<Animator>().SetBool("selecionado", true);
				PlayerPrefs.SetInt("personagemAtual2", auxP);
				SceneManager.LoadScene(2);
			}
		}

	}


	public void InstanciaP(int n){
		Destroy(personagemAtual);
		personagemAtual = Instantiate(personagens[n], gameObject.transform.position, personagens[n].transform.rotation) as GameObject;	
	}
	public void InstanciaM(int n){
		Destroy(mapaAtual);
		mapaAtual = Instantiate(mapas[n], new Vector2(0f,0f), mapas[n].transform.rotation) as GameObject;	
	}


	public void LeftArrowM (){
		if(auxM==0){

			auxM = mapas.Length-1;
		}
		else {

			auxM--;
		}
		InstanciaP(auxM);
	}

	public void RigthArrowM (){
		if(auxM == mapas.Length-1){
			auxM = 0;
		}
		else {
			auxM++;
		}
		InstanciaP(auxM);

	}


	public void LeftArrowP (){
		
		if(auxP==0){
			print("entrou");
			auxP = personagens.Length-1;
		}
		else {

			auxP--;
		}
		InstanciaP(auxP);
	}

	public void RigthArrowP (){
		
		if(auxP == personagens.Length-1){
			auxP = 0;
		}
		else {
			auxP++;
		}
		InstanciaP(auxP);

	}

	// Update is called once per frame
	void Update () {

	}
}
