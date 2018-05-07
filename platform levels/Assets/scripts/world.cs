using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class world : MonoBehaviour {
    public float deathtimer = 5;

    public Text text;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        deathtimer -= Time.deltaTime;
        text.text = "time:" + deathtimer.ToString();
        if (deathtimer <= 0)
        {
            Time.timeScale = 0;
        }
    }
}
