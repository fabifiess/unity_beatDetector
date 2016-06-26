using UnityEngine;
using System.Collections;

public class beatManager : MonoBehaviour {
	public GameObject trigger1;
	public GameObject trigger2;
	public GameObject trigger3;
	public GameObject LedStripe;


	private int counter = 0;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	public void OnTriggerEnter(){
		counter++;
		Debug.Log (counter);
		LedStripe.GetComponent<Renderer> ().material.color = Color.cyan;

	}

	public void OnTriggerExit(){
		LedStripe.GetComponent<Renderer> ().material.color = Color.white;
	}
	*/

	public void enterTrigger(string triggeredObject){
		print ("received "+ triggeredObject + counter);
		counter++;
		LedStripe.GetComponent<Renderer> ().material.color = Color.cyan;
	}

	public void exitTrigger(string triggeredObject){
		print ("received "+ triggeredObject + counter);
		counter++;
		LedStripe.GetComponent<Renderer> ().material.color = Color.white;
	}
}
