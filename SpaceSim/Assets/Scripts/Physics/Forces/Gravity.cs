using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public static readonly double GravitationalConstant = 6.67408*Mathf.Pow(10, -8);
    
    public float EffectiveRange;

    private PhysicsObject _physicsObject;

	// Use this for initialization
	void Start ()
	{
	    _physicsObject = GetComponent<PhysicsObject>();

	    if (_physicsObject == null)
	    {
            Debug.LogWarning("No PhysicsObject Component attached! A default component was added");
            _physicsObject = gameObject.AddComponent<PhysicsObject>();
	    }

	}

    public DVector3 CalculateGravityForce(PhysicsObject other)
    {
        var distance = new DVector3(transform.position - other.transform.position);
        var result= distance.normalized;

        var strength = GravitationalConstant*_physicsObject.Mass*other.Mass/(distance.sqrMagnitude);
        result = result * strength;

        return result;
    }

    void Update()
    {
        var cols = Physics.OverlapSphere(transform.position, EffectiveRange);

        foreach (var col in cols)
        {
            if(col.gameObject == gameObject)
                continue;

            var otherPhysicsObject = col.GetComponent<PhysicsObject>();
            if (otherPhysicsObject == null)
                return;

            var force = CalculateGravityForce(otherPhysicsObject);
            otherPhysicsObject.AddForce(force);
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, EffectiveRange);
    }

}
