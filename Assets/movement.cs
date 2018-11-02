using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    Vector3 speed;
    GameObject bulletPref;

	// Use this for initialization
	void Start () {
        this.speed = Vector3.zero;
        bulletPref = Resources.Load<GameObject>("BulletPrefab");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += speed;

        speed = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        speed *= 0.2f;

        if (Input.GetButton("Fire1"))
        {
            GameObject b = Instantiate(bulletPref);
            b.transform.position = this.transform.position;
            
        }
		
	}
}
