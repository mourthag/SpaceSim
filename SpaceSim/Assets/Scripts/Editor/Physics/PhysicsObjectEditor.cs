using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PhysicsObject))]
public class PhysicsObjectEditor : Editor
{

    private Vector3 _forceToAdd = Vector3.zero;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var pObject = (PhysicsObject) target;

        GUILayout.Space(10f);
        GUILayout.Label("Add Force");
        GUILayout.BeginHorizontal();
        _forceToAdd = EditorGUILayout.Vector3Field("", _forceToAdd);
        if (GUILayout.Button("Add Force"))
        {
            pObject.AddForce(new DVector3(_forceToAdd));
        }
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Label("Velocity: " + pObject.Velocity.ToString());
        GUILayout.EndHorizontal();
    }

    /*void OnInspectorUpdate()
    {
        this.Repaint();
    }*/
}
