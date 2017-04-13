<<<<<<< Updated upstream
﻿using UnityEngine;

public class PilotSelection : MonoBehaviour {

	public string [] pilot;

	public void selectPilot (string pilot){

		for(int i=0; i<pilot.Length; i++ );
		}
	
	

=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

    public GameObject[] pilot = { "Maverick", "Goose", "Faction", "Batmom", "Kitty", "Angel" };


	// Use this for initialization
	void Start () {

        pilot = GameObject.FindGameObjectWithTag("pilot");

        for(int )
	}
	
>>>>>>> Stashed changes
	// Update is called once per frame
	void Update () {
		
	}
}
