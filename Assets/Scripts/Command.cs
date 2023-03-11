using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Command
{
    private ArrayList coffees = new ArrayList();
    public Command(int level)
    {
        int coffee_amount = UnityEngine.Random.Range(1, level + 1);
        for (int i = 0; i < coffee_amount; i++)
        {
            coffees.Add(new Coffee(level));
        }
    }

    public Command(){
        
    }

    public void printCommand()
    {
        foreach (Coffee coffee in coffees)
        {
            Debug.Log("Coffee with " + coffee.getSugars() + " sugars, and " + coffee.getCreams() + " creams.");
        }
    }

    public ArrayList getCoffees()
    {
        return coffees;
    }
    private class Coffee
    {
        private int sugar = 0, cream = 0, espresso = 0, alcohol = 0;
        private bool punched = false, iced = false;
        public Coffee(int level)
        {

            if (level > 1)
            {
                punched = (UnityEngine.Random.Range(0, 2) == 1);
            }
            if (!punched && level > 2)
            {
                iced = (UnityEngine.Random.Range(0, 2) == 1);
            }
            if (level > 3)
            {
                espresso = UnityEngine.Random.Range(0, Math.Min(level, 3));
            }
            if (level > 4)
            {
                alcohol = UnityEngine.Random.Range(0, Math.Min(level, 3));
            }
            sugar = UnityEngine.Random.Range(0, Math.Min(level, 5));
            cream = UnityEngine.Random.Range(0, Math.Min(level, 5));


        }

        public int getCreams()
        {
            return cream;
        }
        public int getSugars()
        {
            return sugar;
        }
        public int getEspresso()
        {
            return espresso;
        }
        public int getAlcohol()
        {
            return alcohol;
        }
        public bool getPunched()
        {
            return punched;
        }
        public bool getIced()
        {
            return iced;
        }
    }

}
