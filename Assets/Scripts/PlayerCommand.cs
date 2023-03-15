using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;



public class PlayerCommand : MonoBehaviour
{

    [SerializeField] ClientLogic client;
    [SerializeField] Moon_animator moon_Animator;
    AudioSource priseDeCommande;
   

    private Command commandClient;
    private Coffee currentCoffee;
    private int coffeeIndex = 0;
    private PlayerMovement playerMovement;
    private bool hasCommand = false;
    private bool commandIsComplete = false;

    private int score;



    void Start()
    {
        
        score = PlayerPrefs.GetInt("score",0);
        PlayerPrefs.Save();
        
        //PlayerPrefs.SetInt("score", score);

        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
        checkFailCondition();

        if (hasCommand)
        {
            checkCommandStatus();
            
            commandClient.printCommand();
        }

        checkWinCondition();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Client") && !hasCommand)
        {
            Debug.Log("Command acquired");
            commandClient = client.getCommand(score);
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
        if(other.gameObject.CompareTag("MathieuPaquette") && hasCommand){
            currentCoffee = null;
        }

    }

    private void checkCommandStatus()
    {

        Debug.Log("Current coffee index is: " + coffeeIndex);
        if (currentCoffee != null && currentCoffee.Equals(commandClient.getCoffee(coffeeIndex)))
        {
            coffeeCompleted();
            if (commandClient.getCoffeesCount() > coffeeIndex + 1)
            {
                coffeeIndex++;

                //show next coffee
            }
            else {
                commandIsComplete = true;

                // from win con

                client.IsHappy(false);
                incrementScore();
                moon_Animator.reduceTimer(15);
                SceneManager.LoadScene("Win_scene");

                // end
            }
        }

    }


    private void coffeeCompleted()
    {
        currentCoffee = null;
    }

    public bool getIsCommandCompleted()
    {
        return commandIsComplete;
    }

     public bool getHasCommand()
    {
        return hasCommand;
    }

    private IEnumerator waitBeforeMove()
    {
        playerMovement.stopMovement();
        yield return new WaitForSeconds(2);
        playerMovement.startMovement();
    }


    public int getCurrentCoffee(){
        return coffeeIndex;
    }

    public int getScore(){
        return PlayerPrefs.GetInt("score");
    }

    public void incrementScore(){
        score++;
        PlayerPrefs.SetInt("score", score);
    }

    private void checkWinCondition()
    {
        if(client.getIsHappy())
        {
            client.IsHappy(false);
            incrementScore();
            moon_Animator.reduceTimer(15);
            SceneManager.LoadScene("Win_scene");
        }
    }

    private void checkFailCondition()
    {
        if(moon_Animator.getTimer() <= 0)
        {
            SceneManager.LoadScene("Death_scenne");
        }
    }
}
