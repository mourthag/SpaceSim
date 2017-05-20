using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PhysicsVisualizer : MonoBehaviour
{
    public PhysicsObject PhysicsObject;
    public bool DrawAllForces;


    void OnDrawGizmos()
    {
        if (PhysicsObject == null)
            return;

        var vel = PhysicsObject.Velocity;
        var target = transform.position + new Vector3((float)vel.x, (float)vel.y, (float)vel.z);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, target);

        //Draw Forces
        Gizmos.color = Color.cyan;

        if (DrawAllForces)
        {
            foreach (var force in PhysicsObject.Forces)
            {
                target = transform.position + new Vector3((float) force.x, (float) force.y, (float) force.z).normalized;
                Gizmos.DrawLine(transform.position, target);
            }
        }
        else
        {
            var force = PhysicsObject.SumForce();
            target = transform.position + new Vector3((float)force.x, (float)force.y, (float)force.z).normalized;
            Gizmos.DrawLine(transform.position, target);
        }

    }
}
