using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible1 : MonoBehaviour {

	public GameObject destroyedVersion;
	private GameObject crate;

	void start()
    {
        crate = GameObject.FindGameObjectWithTag("Crate");
	}

    void OnMouseDown ()
	{
		Instantiate(destroyedVersion, crate.transform.position, crate.transform.rotation);
		Destroy(gameObject);
	}

}

