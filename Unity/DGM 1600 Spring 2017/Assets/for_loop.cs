using UnityEngine;
using System.Collections;

public class for_loop : MonoBehaviour {
	public int bottles = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

		for(int i=99; i>bottles; i--){
			print(i+"bottles of apple beer on the wall");
		}	
	}
}
