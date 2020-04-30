using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarEngine : MonoBehaviour
{
    public Transform path;
    public float maxSteerAngle, maxMotorTorque, maxSpeed, currentSpeed, minNodeDistance;
    public List<Transform> nodes = new List<Transform>();
    private int currentNode = 0;
    public WheelCollider wheelFL, wheelFR;
    //public float; 


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
    void FixedUpdate()
    {
        ApplySteer();
        Drive();
        //Debug.Log(nodes[currentNode]);
        CheckWayPointDistance();
    }

    private void ApplySteer()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        //print(relativeVector);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        wheelFL.steerAngle = newSteer;
        wheelFR.steerAngle = newSteer;
    }

    void Drive()
    {
        currentSpeed = 2 * Mathf.PI * wheelFL.radius * wheelFL.rpm * 60 / 1000;
        if (currentSpeed < maxSpeed)
        {
            wheelFL.motorTorque = maxMotorTorque;
            wheelFR.motorTorque = maxMotorTorque;
        }
        else
        {
            wheelFL.motorTorque = 0;
            wheelFR.motorTorque = 0;
        }
    }

    void CheckWayPointDistance()
    {
        if (Vector3.Distance(transform.position, nodes[currentNode].position) < minNodeDistance)
        {
            if (currentNode == nodes.Count - 1)
            {
                currentNode = 0;
                //Debug.Log("node:0");
            }

            else
                currentNode++;
            //Debug.Log(nodes[currentNode]);
            
        }
        Debug.Log(currentNode);
        //else
           // Debug.Log(nodes[currentNode]);
    }
}
