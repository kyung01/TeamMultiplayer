﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheapHealthBar : MonoBehaviour {
    public Health health;
    public TextMesh text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text =""+ health.health;

    }
}
