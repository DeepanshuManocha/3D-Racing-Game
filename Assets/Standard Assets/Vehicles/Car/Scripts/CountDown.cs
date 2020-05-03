using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    public static float currentTime = 0f;
    float startingTime = 3f;
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();

    }

    void Timer()
    {
        currentTime -= 1 * Time.deltaTime;
        
    }
}
