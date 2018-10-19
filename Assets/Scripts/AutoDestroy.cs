﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {
    public float duration;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (duration < 0)
        {
            Destroy(this.gameObject);
        }
        else {
            duration -= Time.deltaTime;
        }
	}
}
