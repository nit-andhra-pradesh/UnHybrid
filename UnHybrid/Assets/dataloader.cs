﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataloader : MonoBehaviour {

	// Use this for initialization
	IEnumerator  Start () {

	WWW data = new WWW("http://localhost/game/dataa.php");
	yield return data;
	string text = data.text;
	print(text);

	}
	
	
}
