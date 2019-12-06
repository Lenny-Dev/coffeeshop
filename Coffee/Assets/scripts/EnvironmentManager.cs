using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    private string forecast;
    private bool gettingDarker;
    public float hourChangeRate;
    private float hour = 0;

    public GameObject sky;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hour += 1 * Time.deltaTime;
        if(hour >= 24){
            hour = 0;
        }
        Color c = sky.GetComponent<SpriteRenderer>().color;

        if(c.a >= 1){
            gettingDarker = !gettingDarker;
        }
        if(c.a <= 0){
            gettingDarker = !gettingDarker;
        }

        if(gettingDarker){
            sky.GetComponent<SpriteRenderer>().color = new Color(c.r, c.g, c.b, c.a += hourChangeRate * Time.deltaTime);
        }else{
            sky.GetComponent<SpriteRenderer>().color = new Color(c.r, c.g, c.b, c.a -= hourChangeRate * Time.deltaTime);
        }

        Debug.Log("Hour " + hour);
    }

    public string TimeOfDay(){
        return "morning";
    }
    public string WeatherForecast(){

        return "sunny";
    }
}
