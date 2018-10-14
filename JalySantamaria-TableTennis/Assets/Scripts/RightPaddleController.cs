using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleController : MonoBehaviour {

    public float MotionSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow)) {

            //Esta instrucción mueve el GameObject hacia su izquierda        
            this.transform.Translate(Vector3.left * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {

            //Esta instrucción mueve el GameObject hacia su derecha       
            this.transform.Translate(Vector3.right * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {

            this.transform.Translate(Vector3.up * MotionSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {

            this.transform.Translate(Vector3.down * MotionSpeed);
        }

    }
}
