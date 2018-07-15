using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushController : MonoBehaviour {

	private Animator anim;
	public int health = 900;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
	}
	
	public void DisableMush ()
	{
		gameObject.SetActive (false);
	}
}