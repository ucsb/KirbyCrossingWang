using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible1 : MonoBehaviour {

    	public GameObject Wooden_Crate_Cracked;
	public Transform Crate_01;
	
	void OnMouseDown ()
	{
		//Instantiate(Wooden_Crate_Cracked, transform.position, transform.rotation);
		Instantiate(Wooden_Crate_Cracked, Crate_01.position, Crate_01.rotation);
		Destroy(gameObject);
	}
}
