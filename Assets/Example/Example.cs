﻿using Assets.Tests.Performance;
using UnityEngine;

public class Example : MonoBehaviour {

	void Start () {
		
		var stringTable = new StringTable();
		
		var result = stringTable
			.Title("Test Title")
			.Header("Should Be 13", "Second", "Third", "Fourth")
			.Row("1", "2234433242423", "3", "4", "dsfds")
			.Row("1", "23423423423", "334", "4")
			.Row("1", "2", "3", "4")
			.Row("1", "2", "3", "4")
			.Print();
		
		Debug.Log(result);
	}
}