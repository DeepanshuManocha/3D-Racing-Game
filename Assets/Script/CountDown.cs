using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    public static float currentTime = 0f;
    float startingTime = 3f;
    [SerializeField] Text countDownText;
    [SerializeField]Animator goAnim;

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
        countDownText.text = currentTime.ToString("0");

        if (currentTime < 2)
            countDownText.color = new Color(255, 255, 0, 255);
        if (currentTime < 1)
            countDownText.color = Color.red;
        if (currentTime < 0)
        {
            countDownText.color = new Color(0, 0, 0, 0);
            goAnim.SetBool("GO", true);
        }
    }
}
