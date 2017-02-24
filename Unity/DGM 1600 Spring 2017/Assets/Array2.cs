using UnityEngine;
using System.Collections;

public class Array2 : MonoBehaviour {

	public string[] ingredients= {"eggs", "chocolate chips", "brown sugar", "flour"};

	// Use this for initialization
	void Start () {

		for(int i=0; i<ingredients.Length; i++)
		{
			print("need" + ingredients[i]);
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
