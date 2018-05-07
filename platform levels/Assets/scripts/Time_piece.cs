using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_piece : MonoBehaviour {
   public GameObject world;
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        world.GetComponent<world>().deathtimer += 5;
        DestroyObject(gameObject);
    }
}
