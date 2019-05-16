using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotPoint : MonoBehaviour {

	public GameObject referenceObject;

	Vector3 offset= new Vector3(0,0,0);
	
	// Update is called once per frame
	void Update () {
		referenceObject.transform.position = transform.position + offset;
		referenceObject.transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);

		if(transform.localEulerAngles.z>65f){
			offset += referenceObject.transform.right * 0.1f;
	}

		if(transform.localEulerAngles.z<-45f){
			offset += referenceObject.transform.right * -0.1f;
		}
}
}