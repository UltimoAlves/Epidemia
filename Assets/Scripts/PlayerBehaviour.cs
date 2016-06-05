using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	PlayersBehaviour playerScr;
	public GameObject player; 
	public GameObject[] personagens;
	public int velocidadeAndar;
	public bool olhandoDireita;
	public bool olhandoCima;
	public bool esq;
	public bool dir;
	public bool cim;
	public bool bax;
	public bool podePular;
	public int alturaPulo;
	public GameObject bala;



	void Awake (){
		if (gameObject.name == "player1"){
			olhandoDireita = true;
			dir = true;
			esq= false;
			playerScr = new PlayersBehaviour(1);
			player = Instantiate(personagens[PlayerPrefs.GetInt("personagemAtual")], gameObject.transform.position, gameObject.transform.rotation) as GameObject;	
		}
		else if (gameObject.name == "player2" && PlayerPrefs.GetInt("gameplay")==2){
			olhandoDireita = false;
			dir = false;
			esq= true;
			playerScr = new PlayersBehaviour(2);
			player = Instantiate(personagens[PlayerPrefs.GetInt("personagemAtual2")], gameObject.transform.position, gameObject.transform.rotation) as GameObject;	
			Vector3 scale = player.transform.localScale;
			scale.x *= -1;
			player.transform.localScale = scale;
		}
	}



	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		if (gameObject.name == "player1"){


			if(Input.GetKey(KeyCode.LeftArrow)){
				esq = true;
				dir = false;
				playerScr.AndarX(player, -velocidadeAndar);
			} else if(Input.GetKey(KeyCode.RightArrow)){
				esq = false;
				dir = true;
				playerScr.AndarX(player, velocidadeAndar);
			} else if(Input.GetKey(KeyCode.UpArrow)){
				bax = false;
				cim = true;
				playerScr.AndarY(player, velocidadeAndar);
			} else if(Input.GetKey(KeyCode.DownArrow)){
				bax = true;
				cim = false;
				playerScr.AndarY(player, -velocidadeAndar);
			}

			else {
				playerScr.Parar(player);
			}


		}
		else if (gameObject.name == "player2"){
			if(Input.GetKey(KeyCode.A)){
				esq = true;
				dir = false;
				playerScr.AndarX(player, -velocidadeAndar);
			} else if(Input.GetKey(KeyCode.D)){
				esq = false;
				dir = true;
				playerScr.AndarX(player, velocidadeAndar);
			} 
			else {
				playerScr.Parar(player);
			}
		}

		if(esq && olhandoDireita){

			InverteX();
		}
		if(dir && !olhandoDireita){
			InverteX();
		}


		if(bax && olhandoCima){

			InverteX();
		}
		if(cim && !olhandoCima){
			InverteX();
		}

	}

	void InverteX(){
		if (olhandoDireita == true){
			olhandoDireita = false;
		}
		else if (olhandoDireita == false){
			olhandoDireita = true;
		} 
		Vector3 scale = player.transform.localScale;
		scale.x *= -1;
		player.transform.localScale = scale;
	}

	void InverteY(){
		if (olhandoCima == true){
			olhandoCima = false;
		}
		else if (olhandoCima == false){
			olhandoCima = true;
		} 
		Vector3 scale = player.transform.localScale;
		scale.y *= -1;
		player.transform.localScale = scale;
	}

}
