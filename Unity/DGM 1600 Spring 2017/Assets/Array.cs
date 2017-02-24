using UnityEngine;
using System.Collections;

public class Array: MonoBehaviour {

	public string[] friends= {"Bob", "Sue", "Charlie", "Ann"};

	// Use this for initialization
	void Start () {
		for(int i=0; i<friends.Length; i++)
		{
			print("Hello" + friends[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


