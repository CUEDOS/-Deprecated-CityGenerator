using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.XR.ARFoundation;
using Samspace;
namespace Samspace
{
    [CustomEditor(typeof(SimpleCityGenerator))]
    public class SimpleCityGeneratorEditor : Editor
    {

        //public static bool OrginChanger = false;


        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            SimpleCityGenerator spawner = (SimpleCityGenerator)target;

            //OrginChanger = EditorGUI.Toggle(new Rect(0, 5, 1, 20), "Move Origin", OrginChanger);

            if (GUILayout.Button("Spawn Objects"))
            {
                spawner.EditorSpawn();

            }

            if (GUILayout.Button("Remove Spawns"))
            {
                spawner.DestroyAll();
            }



        }
    }

}