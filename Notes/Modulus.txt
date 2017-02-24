using UnityEngine;
using System.Collections;

public class Operators : MonoBehaviour {
	public int One = 1;
	public int Two = 2;
	public int Three = 3;

	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	// Math operators are universal with all scripting languages.

	//Addition
	Debug.Log(One+Two);
	//Subtraction
	Debug.Log(One-Two);
	//Multiplication
	Debug.Log(One*Two);
	//Division
	Debug.Log(One/Two);
	//Modulus- the remainder after you divide ie: 2 / 5 = 2.5 the .5 would be the modulus.
		//Example:
		// var x = 5;
		// var y = 2;
		// var z = x % y;
	Debug.Log(One % Two);
	//Increment- can be increased by a set value or a variable ie: picking up ammo and increasing by one, or searching objects and finding 19 feathers in one nest or 3 feathers in another.
	Debug.Log(One++Two)
	//Decrement- decreasing by a set value
	Debug.Log(One--Two)
	//Operator Precedence is also universal
	

	}
}
