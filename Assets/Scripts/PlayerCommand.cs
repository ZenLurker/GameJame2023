using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCommand : MonoBehaviour
{

    [SerializeField] ClientLogic client;

    private Command commandClient;
    private Coffee currentCoffee;
    private int coffeeIndex = 0;
    private PlayerMovement playerMovement;
    private bool hasCommand = false;
    private bool commandIsComplete = false;


    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
        if (hasCommand)
        {
            checkCommandStatus();
            //if(playerMovement.OnSpacePress()){

            //}
            commandClient.printCommand();
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Client") && !hasCommand)
        {
            Debug.Log("Command acquired");
            commandClient = client.getCommand();
            hasCommand = true;

        }

        if (other.gameObject.CompareTag("Client") && commandIsComplete && hasCommand)
        {
            client.IsHappy(true);
            hasCommand = false;

        }

        if (other.gameObject.CompareTag("Client") && !commandIsComplete && hasCommand)
        {
            client.IsHappy(false);
        }

        if (other.gameObject.CompareTag("CoffeeStation") && hasCommand && !commandIsComplete)
        {
            if (playerMovement.canMove)
            {
                StartCoroutine("waitBeforeMove");
                currentCoffee = new Coffee();
            }


        }

        if (other.gameObject.CompareTag("SugarStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            currentCoffee.addSugar();

        }

        if (other.gameObject.CompareTag("CreamStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            currentCoffee.addCream();

        }

        if (other.gameObject.CompareTag("AlcoholStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            currentCoffee.addAlcohol();

        }

        if (other.gameObject.CompareTag("EnergyStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            currentCoffee.addEspresso();

        }

        if (other.gameObject.CompareTag("PunchedStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            currentCoffee.addPunched();

        }

        if (other.gameObject.CompareTag("IcedStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            currentCoffee.addIced();

        }

        //Garbage Collector (Mathieu Paquette)
        if(other.gameObject.CompareTag("MathieuPaquette")){
            currentCoffee = null;
        }

    }

    private void checkCommandStatus()
    {

        if (currentCoffee != null && currentCoffee.Equals(commandClient.getCoffee(coffeeIndex)))
        {
            coffeeCompleted();
            if (commandClient.getCoffees().Count > coffeeIndex + 1)
            {
                coffeeIndex++;
            }
            else commandIsComplete = true;
        }

    }


    private void coffeeCompleted()
    {
        currentCoffee = null;
    }

    private IEnumerator waitBeforeMove()
    {
        playerMovement.stopMovement();
        yield return new WaitForSeconds(2);
        playerMovement.startMovement();
    }


}
