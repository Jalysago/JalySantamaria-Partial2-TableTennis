using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleController : MonoBehaviour {

    public float MotionSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D)) {

            //Esta instrucción mueve el GameObject hacia su izquierda        
            this.transform.Translate(Vector3.left * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.A)) {

            //Esta instrucción mueve el GameObject hacia su derecha       
            this.transform.Translate(Vector3.right * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.W)) {

            this.transform.Translate(Vector3.up * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.S)) {

            this.transform.Translate(Vector3.down * MotionSpeed);
        }
    }
}
