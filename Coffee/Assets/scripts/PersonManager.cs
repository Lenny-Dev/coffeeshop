using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    /*
        - Manages a persons movements 
        - Manages a persons dicision
    */

    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }


    void OnBecameInvisible (){
        // destroy this object when outside of camera range
        Destroy(this.gameObject);
    }
    

    private void move(){
        transform.position = new Vector2(this.transform.position.x - speed * Time.deltaTime, transform.position.y);
    }

    public bool choice(){
        bool buy = false;

        int x = Random.Range(0,2);

        if(x == 1){
            // decided to buy
            buy = true;
            Color myGreen = new Color(0.4297548f, 1f, 0.3726415f, 1f);
            gameObject.GetComponent<SpriteRenderer>().color = myGreen;
            //gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }else if(x == 0){
            //decide not to buy
            buy = false;
            
            Color myRed = new Color(1f, 0.3780342f, 0.3725491f, 1f);
            gameObject.GetComponent<SpriteRenderer>().color = myRed;
            //gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        return buy;
    }

    private void decidedToBuy(){
        // do some animations of getting the coffee

        // animation for drinking the coffee

        // animation of the reaction of the coffee

        // leave the scene
    }

    private void decidedNotToBuy(){
        // animation showing why they don't want to buy the coffee

        // leave the scene
    }
}
