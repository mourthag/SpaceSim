using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTransform : MonoBehaviour
{
    public DVector3 position;

	// Use this for initialization
	void Start () {
        position = new DVector3(transform.position);
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdatePosition();
	}

    public void UpdatePosition()
    {
        var approximatedPosition = new Vector3((float)position.x, (float)position.y, (float)position.z);
        transform.position = approximatedPosition;
    }
}
