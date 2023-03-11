using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCommand : MonoBehaviour
{

    [SerializeField] ClientLogic client;
    private Command commandClient;
    private Command fulfillmentCommand;
    private int currentCovfefe;
    private PlayerMovement playerMovement;
    bool hasCommand = false;
    bool commandIsComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        fulfillmentCommand = new Command();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
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
            commandClient = client.getCommand();
            currentCovfefe = 0;
            hasCommand = true;
        }

        if (other.gameObject.CompareTag("Client") && commandIsComplete && hasCommand)
        {
            client.IsHappy(true);
            hasCommand = false;
            fulfillmentCommand = null;
        }

        if (other.gameObject.CompareTag("Client") && !commandIsComplete && hasCommand)
        {
            client.IsHappy(false);
        }

        if (other.gameObject.CompareTag("CoffeeStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addCoffee();

        }

        if (other.gameObject.CompareTag("SugarStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addSugar(currentCovfefe);

        }

        if (other.gameObject.CompareTag("CreamStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addCream(currentCovfefe);

        }

        if (other.gameObject.CompareTag("AlcoholStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addAlcohol(currentCovfefe);

        }

        if (other.gameObject.CompareTag("EspressoStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addEspresso(currentCovfefe);

        }

        if (other.gameObject.CompareTag("PunchedStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addPunched(currentCovfefe);

        }

        if (other.gameObject.CompareTag("IcedStation") && hasCommand && !commandIsComplete)
        {
            StartCoroutine("waitBeforeMove");
            fulfillmentCommand.addIced(currentCovfefe);

        }

    }

    private void checkCommandStatus()
    {
        if (fulfillmentCommand.getCoffees().Count != 0)
        {
            if (fulfillmentCommand.getCoffee(currentCovfefe).Equals(commandClient.getCoffee(currentCovfefe)))
            {

                currentCovfefe++;

            }

            if (currentCovfefe == commandClient.getCoffees().Count)
            {
                commandIsComplete = true;
            }
        }

    }

    private IEnumerator waitBeforeMove()
    {
        playerMovement.stopMovement();
        yield return new WaitForSeconds(2);
        playerMovement.startMovement();
    }


}
