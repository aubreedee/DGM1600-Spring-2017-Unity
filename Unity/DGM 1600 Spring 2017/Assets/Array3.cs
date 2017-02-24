using UnityEngine;
using System.Collections;

public class Array3 : MonoBehaviour {

	public string[] joke= {"goes to college", "is so fat she has her own gravity", "is so fat she thought the rings of Saturn were hula hoops", "is so poor she can't afford to pay attention"};


	// Use this for initialization
	void Start () {
		for(int i=0; i<joke.Length; i++ )
		{
			print ("yo mamma " + joke[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
