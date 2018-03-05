using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISeeYou : MonoBehaviour {

    public bool nowYouSeeMe;

	// Use this for initialization
	void Start ()
    {
        nowYouSeeMe = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            nowYouSeeMe = true;
            Debug.Log("EnemySeesPlayer");
        }
	}
}
