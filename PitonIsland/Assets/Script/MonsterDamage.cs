using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MonsterDamage : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "MonsterAi") {
			col.GetComponent<AIRun> ().healthMonster -= 50;
		}
	}
}
