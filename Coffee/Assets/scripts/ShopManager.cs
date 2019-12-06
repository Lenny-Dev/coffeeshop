using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    private float private_revenue;
    public float revenue;
    public float costOfCoffee;

    public TMP_Text revenueText;
    public TMP_Text costText;
    public Slider slider;
    
    void Start()
    {
        revenue = private_revenue;
        revenueText.text = "revenue : " + private_revenue.ToString("c2");
        costText.text = "cost : " + costOfCoffee.ToString("c2");
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider){

        if(collider.tag != "person")
            return;
        
        bool decidedToBuy = collider.GetComponent<PersonManager>().choice();

        if(decidedToBuy){
            Debug.Log("Decided to buy");
            updateCash(costOfCoffee);
        }
    }

    void updateCash(float cost){
        // updating backend
        private_revenue += costOfCoffee;
        
        //Update UI
        Debug.Log("You have made : " + private_revenue);
        revenueText.text = "revenue : " + private_revenue.ToString("c2");
    }

    public void ChangePrice(){
        Debug.Log("slider value - " + slider.value);
        costOfCoffee = 1 * slider.value;
        costText.text = "cost : " + costOfCoffee.ToString("c2");
    }
}
