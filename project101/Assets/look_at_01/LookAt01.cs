using UnityEngine;
using System.Collections;

public class LookAt01 : MonoBehaviour {

	public GameObject lookAtGo;
	Transform lookAtTrans;
	Vector3 upDirection = new Vector3(0,0,1);

	void Start ()
	{
		lookAtTrans = lookAtGo.transform;
	}

	// Update is called once per frame
	void Update ()
	{
		transform.LookAt( lookAtTrans );	
	}
}
