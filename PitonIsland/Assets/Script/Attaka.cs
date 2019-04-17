using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaka : MonoBehaviour

{
	public GameObject triggerDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown ("Fire1"))
		{
			gameObject.GetComponent<Animator>().SetTrigger("Attak1");
			triggerDamage.SetActive(true);
		}
		
		
		
		if (Input.GetButtonDown ("Fire2"))
		{
			gameObject.GetComponent<Animator>().SetTrigger("Attak2");
		}
		
    }
}