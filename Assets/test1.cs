using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {
	Classy myclassy = new Classy();
	// Use this for initialization
	void Start () {

		myclassy.test(3);
	}
	
	// Update is called once per frame
	void Update () {
		myclassy.test(1231231);
	}
}
