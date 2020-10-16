using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputField : MonoBehaviour {

	string inputString = "";
	int lengthOf = 4;

	void Start () {

	}

	void OnGUI(){
		inputString = GUILayout.TextField (inputString, lengthOf);
	}

	void Update () {
		PlayerPrefs.SetString ("input", inputString);
	}
}
