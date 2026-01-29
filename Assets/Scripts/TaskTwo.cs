using UnityEngine;

public class TaskTwo : MonoBehaviour
{

    // Variable Declaration
    public double coverPrice = 2; //Price consumers pay
    public int bookAmount = 2; //Amount of books purchases
    public double customerPrice; //product 
    public double bookstoreDiscountedPrice; //

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Create the amount the consumers paid
    public void consumerPrice ()
    {
        Debug.LogFormat("You have input ", bookAmount, " books that cost ", coverPrice, " to consumers individually.");
        customerPrice = coverPrice * bookAmount;
        Debug.LogFormat("The total amount of money earned from consumers is: ", customerPrice);
    }

    //Give discount to bookstore
    public void bookstoreDiscount()
    {
        double bookstoreDiscountedPrice = customerPrice * 0.4;
    }

    //Create shipping cost
    public void shippingCost ()
    {

    }

    //Compare the price consumers paid to the price the bookstore paid
    public void profitComparison ()
    {

    }
}
