using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColor : MonoBehaviour
{
    [SerializeField] private FlexibleColorPicker fcp;
    [SerializeField] private Material[] material;

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<material.Length;i++)
        {
           material[i].color = fcp.color;
        }
        CarColor.color = fcp.color;
    }
}
