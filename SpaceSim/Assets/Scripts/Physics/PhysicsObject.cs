using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    public float Mass;

    private DVector3 _velocity;
    private DVector3 _acceleration;

    private PhysicsTransform _ptransform;
    private readonly List<DVector3> _forces = new List<DVector3>();

    public DVector3 Velocity
    {
        get { return _velocity; }
    }

    public List<DVector3> Forces
    {
        get { return _forces; }
    }


    // Use this for initialization
	void Start ()
	{
        _velocity = DVector3.zero;
        _ptransform = gameObject.AddComponent<PhysicsTransform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _acceleration = SumForce()/Mass;

        _velocity = _acceleration*Time.deltaTime;
        _ptransform.position += Velocity * Time.deltaTime;

	}

    public DVector3 SumForce()
    {
        var resultingForce = Forces.Aggregate(DVector3.zero, (current, force) => current + force);
        if (Forces.Count > 100)
        {
            Forces.Clear();
            Forces.Add(resultingForce);
        }
        return resultingForce;
    }

    public double Impulse()
    {
        return Velocity.magnitude*Mass;
    }

    public void AddForce(DVector3 force)
    {
        Forces.Add(force);
    }
}
