using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarEngine : MonoBehaviour
{
    public Transform path;
    public float maxSteerAngle=45f;
    private List<Transform> nodes = new List<Transform>();
    private int currentNode = 0;
    public WheelCollider wheelFL, wheelFR;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] pathTransform = path.GetComponentsInChildren<Transform>();
        for (int i = 0; i < pathTransform.Length; i++)
        {
            if (pathTransform[i] != path.transform)
                nodes.Add(pathTransform[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ApplySteer();
    }

    private void ApplySteer()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        //print(relativeVector);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        wheelFL.steerAngle = newSteer;
        wheelFR.steerAngle = newSteer;


    }
}
