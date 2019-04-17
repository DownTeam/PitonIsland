using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShovel : MonoBehaviour
{
	public int timeStart;
	public int timeEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart +=1;
		if (timeStart >= timeEnd){
			timeStart = 0;
			gameObject.SetActive (false);
		}
    }
}
