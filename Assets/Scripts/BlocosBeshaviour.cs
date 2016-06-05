using UnityEngine;
using System.Collections;

public class BlocosBeshaviour : MonoBehaviour {
	public GameObject infectado;
	public GameObject infectados;
	int aux;
	// Use this for initialization
	void Start () {
		aux = Random.Range(0,6);
		if(aux==1){
			gameObject.GetComponent<Animator>().SetBool("1", true);
		}
		else if(aux==2){
			gameObject.GetComponent<Animator>().SetBool("2", true);
		}
		else if(aux==3){
			gameObject.GetComponent<Animator>().SetBool("3", true);
		}
		else if(aux==3){
			gameObject.GetComponent<Animator>().SetBool("3", true);
		}
		else if(aux==5){
			gameObject.GetComponent<Animator>().SetBool("5", true);
		}


	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D colisao){
		if(colisao.gameObject.tag == "Player"){
			infectados = Instantiate(infectado, gameObject.transform.position, infectado.transform.rotation)as GameObject;
			if(aux==1){
				infectados.GetComponent<Animator>().SetBool("1", true);
			}
			else if(aux==2){
				infectados.GetComponent<Animator>().SetBool("2", true);
			}
			else if(aux==3){
				infectados.GetComponent<Animator>().SetBool("3", true);
			}
			else if(aux==3){
				infectados.GetComponent<Animator>().SetBool("3", true);
			}
			else if(aux==5){
				infectados.GetComponent<Animator>().SetBool("5", true);
			}

			
		}

	}
}
