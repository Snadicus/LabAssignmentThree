using System.Collections;
using UnityEngine;

public class TaskOne : MonoBehaviour
{
    public int amountPaid;
    
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
            amountPaid -= 100;
        }
        else if (amountPaid >= 50)
        {
           // Debug.Log("The bill is a $50 bill.");
            amountPaid -= 50;
        }
        else if (amountPaid >= 20)
        {
            //Debug.Log("The bill is a $20 bill.");
            amountPaid -= 20;
        }
        else if (amountPaid >= 10)
        {
            //Debug.Log("The bill is a $10 bill.");
            amountPaid -= 10;
        }
        else if (amountPaid >= 5)
        {
           // Debug.Log("The bill is a $5 bill.");
            amountPaid -= 5;
        }
        else if (amountPaid >= 1)
        {
            //Debug.Log("The bill is a $1 bill.");
            amountPaid -= 1;
        }
    }    
    void Count(int bill)
    {
        int count100;
        int count50;
        int count20;
        int count10;
        int count5;
        int cuont1;
    }
}
