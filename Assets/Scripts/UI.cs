using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coffeeCount;
    [SerializeField] TextMeshProUGUI sugarCount;
    [SerializeField] TextMeshProUGUI creamCount;
    [SerializeField] TextMeshProUGUI icedCount;
    [SerializeField] TextMeshProUGUI punchedCount;
    [SerializeField] TextMeshProUGUI energyShotsCount;
    [SerializeField] TextMeshProUGUI alcoholCount;
    [SerializeField] TextMeshProUGUI scoreCount;
    [SerializeField] TextMeshProUGUI gameMessage;



    [SerializeField] ClientLogic client;
    [SerializeField] PlayerCommand player;

    Command command;

    // Start is called before the first frame update
    void Start()
    {
        gameMessage.text = "Go see the client!";

    }

    // Update is called once per frame
    void Update()
    {

        if (player.getHasCommand())
        {
            gameMessage.text = "";
        }



        if (!(player.getIsCommandCompleted()))
        {
            if(player.getHasCommand()) {
                coffeeCount.text = "Coffees: " + (player.getCurrentCoffee()+1) + " of " + command.getCoffeesCount().ToString();
                sugarCount.text = "Sugars: " + command.getCoffee(player.getCurrentCoffee()).getSugars();
                creamCount.text = "Creams: " + command.getCoffee(player.getCurrentCoffee()).getCreams();
                icedCount.text = "Iced: " + command.getCoffee(player.getCurrentCoffee()).getIced();
                punchedCount.text = "Punched: " + command.getCoffee(player.getCurrentCoffee()).getPunched();
                energyShotsCount.text = "Energy Level: " + command.getCoffee(player.getCurrentCoffee()).getEspresso();
                alcoholCount.text = "Alcohol: " + command.getCoffee(player.getCurrentCoffee()).getAlcohol();
            }
            
        }    
        else
        {
            coffeeCount.text = "Command is complete!";
            gameMessage.text = "Return to client!";

            sugarCount.text = "Sugars";
            creamCount.text = "Creams";
            icedCount.text = "Iced";
            punchedCount.text = "Punched";
            energyShotsCount.text = "Energy Level";
            alcoholCount.text = "Alcohol";
            
        }

        scoreCount.text = player.getScore().ToString();


    }

    public void setCommand(Command command) {
        this.command = command;
    }     




}
