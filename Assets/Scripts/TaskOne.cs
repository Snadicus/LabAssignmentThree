using System.Collections;
using UnityEngine;

public class TaskOne : MonoBehaviour
{
    public int amountPaid;
    int count100;
    int count50;
    int count20;
    int count10;
    int count5;
    int count1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (amountPaid > 0)
        {
            CheckMoney();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckMoney()
    {
        // Check if payment is over 100
        if (amountPaid >= 100)
        {
            //Debug.Log("The bill is a $100 bill.");

            // subtract 100 from total pay
            amountPaid -= 100;
            Count(100);
        }
        // Check if payment is over 50
        else if (amountPaid >= 50)
        {
            // Debug.Log("The bill is a $50 bill.");

            // subtract 50 from total pay
            amountPaid -= 50;
            Count(50);
        }
        // Check if payment is over 20
        else if (amountPaid >= 20)
        {
            //Debug.Log("The bill is a $20 bill.");

            // subtract 20 from total pay
            amountPaid -= 20;
            Count(20);
        }
        // Check if payment is over 10
        else if (amountPaid >= 10)
        {
            //Debug.Log("The bill is a $10 bill.");

            // subtract 10 from total pay
            amountPaid -= 10;
            Count(10);
        }
        // Check if payment is over 5
        else if (amountPaid >= 5)
        {
            // Debug.Log("The bill is a $5 bill.");

            // subtract 5 from total pay
            amountPaid -= 5;
            Count(5);
        }
        // Check if payment is over 1
        else if (amountPaid >= 1)
        {
            //Debug.Log("The bill is a $1 bill.");

            // subtract 1 from total pay
            amountPaid -= 1;
            Count(1);
        }
    }    
    void Count(int bill)
    {
        // Add count for each respective bill
        if (bill == 100)
        {
            count100 += 1;
        }
        else if (bill == 50)
        {
            count50++;
        }
        else if (bill == 20)
        {
            count20++;
        }
        else if (bill == 10)
        {
            count10++;
        }
        else if (bill == 5)
        {
            count5++;
        }
        else if (bill == 1)
        {
            count1++;
        }
        // When no more money needs to be paid, print amount
        if (amountPaid == 0)
        {
            Debug.Log($"{count100} $100 bills. {count50} $50 bills. {count20} $20 bills. {count10} $10 bills. {count5} $5 bills. {count1} $1 bills.");
        }
    }
}
