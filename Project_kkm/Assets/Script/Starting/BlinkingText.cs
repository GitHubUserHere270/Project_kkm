using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour {

    Text myText;

	// Use this for initialization
	void Start () {
        InvokeRepeating("blinkText", 0.5f, 0.5f);
	}

    void blinkText() {

        if (myText.text == "") {

            myText.text = "TAP TO START";

        } else {
            myText.text = "";
        }
    }
}
