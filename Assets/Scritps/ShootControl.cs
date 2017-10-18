using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour {

    
    public Transform postion;
    public Rigidbody gameobject;
    public float force = 5;
    Color[] colors;
    // Use this for initialization
    void Start () {
         colors = new Color[4];
        colors[0] = Color.yellow;
        colors[1] = Color.red;
        colors[2] = Color.gray;
        colors[3] = Color.green;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float rand = Random.Range(0.2f, 1);
            int ranColor = Random.Range(0,4);
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(gameobject, postion.position, postion.rotation) as Rigidbody;
            rocketInstance.gameObject.transform.localScale = new Vector3(rand, rand, rand);
            rocketInstance.GetComponent<Renderer>().material.color = colors[ranColor];
            rocketInstance.AddForce(postion.forward * force);
        }
    }
}
