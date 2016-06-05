using UnityEngine;
using System.Collections;

public class PlayersBehaviour : MonoBehaviour {
	public float velJump;
	public float velRun;
	public bool podePular;
	public Vector2 posBala;
	public bool esq;
	public bool dir;
	public bool instanciaBala;
	public int tempInstaBala;
	public float vidaAtual;
	public int numPlayer;

	public PlayersBehaviour(int np){
		//gameObject = personagem;
		numPlayer = np;
	}


	public void AndarY(GameObject player, int velocidade){
		if(velocidade > 0){	
			player.GetComponent<Animator>().SetBool("up", true);
			player.GetComponent<Animator>().SetBool("side", false);
			player.GetComponent<Animator>().SetBool("down", false);

		} else {
			player.GetComponent<Animator>().SetBool("down", true);
			player.GetComponent<Animator>().SetBool("side", false);
			player.GetComponent<Animator>().SetBool("up", false);

		}
		player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, velocidade);
	}
	public void AndarX(GameObject player, int velocidade){	
		player.GetComponent<Animator>().SetBool("down", false);
		player.GetComponent<Animator>().SetBool("side", true);
		player.GetComponent<Animator>().SetBool("up", false);
		player.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidade, player.GetComponent<Rigidbody2D>().velocity.y);
	}
	public void Parar(GameObject player){
		player.GetComponent<Animator>().SetBool("down", false);
		player.GetComponent<Animator>().SetBool("side", false);
		player.GetComponent<Animator>().SetBool("up", false);
		player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

	}
	void Start () {

		//	olhandoDireita = true;
		//	vidaAtual = vidaCheia;

	}
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D colisao){
		if(colisao.gameObject.tag == "Enemy"){
			//Destroy(player1);
		}

	}
}
