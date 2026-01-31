using UnityEngine;

public class TaskTwo : MonoBehaviour
{

    // Variable Declaration
    public double coverPrice = 2; //Price consumers pay
    public int bookAmount = 2; //Amount of books purchases
    private double customerPrice; //Product of coverPrice and bookAmount
    private double bookstoreDiscountedPrice; //Product of customerPrice and the discount 0.4
    private double bookstorePriceFinal; //Final sum of cost to bookstore
    private double comparedPrice; //Difference of the customerPrice and the bookstorePriceFinal

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        consumerPrice();
        bookstoreDiscount();
        shippingCost();
        profitComparison();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Create the amount the consumers paid
    public void consumerPrice ()
    {
        Debug.Log("You have input " + bookAmount + " books that cost $" + coverPrice + " to consumers individually.");
        customerPrice = coverPrice * bookAmount;
        Debug.Log("The total amount of money earned from consumers is: $" + customerPrice);
    }

    //Give discount to bookstore
    public void bookstoreDiscount()
    {
        bookstoreDiscountedPrice = customerPrice * 0.4;
        Debug.Log("The amount the bookstore paid for those books with their 40% discount is: $" + bookstoreDiscountedPrice);
    }

    //Create shipping cost
    public void shippingCost ()
    {
        bookstorePriceFinal = bookstoreDiscountedPrice + 3 + (0.75 * bookAmount);
        Debug.Log("With shipping applied to the discounted price, that total becomes: $" + bookstorePriceFinal);
    }

    //Compare the price consumers paid to the price the bookstore paid
    public void profitComparison ()
    {
        comparedPrice = customerPrice - bookstorePriceFinal;
        Debug.Log("With the amount earned form consumers, $" + customerPrice + ", and the bookstore price, $" + bookstorePriceFinal + ", the total amount of profit earned was: $"+ comparedPrice);
    }
}
