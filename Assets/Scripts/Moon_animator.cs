using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon_animator : MonoBehaviour
{

    SpriteRenderer spriterenderer;
    [SerializeField] Sprite moon_0;
    [SerializeField] Sprite moon_1;
    [SerializeField] Sprite moon_2;
    [SerializeField] Sprite moon_3;
    [SerializeField] Sprite moon_4;
    [SerializeField] Sprite moon_6;
    [SerializeField] Sprite moon_7;
    [SerializeField] Sprite moon_8;
    [SerializeField] Sprite moon_hour1;
    [SerializeField] Sprite moon_hour2;    
    [SerializeField] Sprite moon_hour3;
    [SerializeField] Sprite moon_hour4;
    [SerializeField] Sprite moon_hour5;
    [SerializeField] Sprite moon_hour6;
    [SerializeField] Sprite moon_hour7;
    [SerializeField] Sprite moon_hour8;
    [SerializeField] Sprite moon_hour9;
    [SerializeField] Sprite moon_hour10;
    [SerializeField] Sprite moon_hour11;
    [SerializeField] Sprite moon_hour12;

    public float timer = 15f;
    private float originalTimer;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        originalTimer = timer;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        if(timer >= originalTimer * 20/21){
            spriterenderer.sprite = moon_0;
        }
        else if(timer>=originalTimer *19/21){
            spriterenderer.sprite = moon_1;
        }
        else if(timer>=originalTimer *18/21){
            spriterenderer.sprite = moon_2;
        }
        else if(timer>=originalTimer *17/21){
            spriterenderer.sprite = moon_3;
        }
        else if(timer>=originalTimer *16/21){
            spriterenderer.sprite = moon_4;
        }
        else if(timer>=originalTimer *15/21){
            spriterenderer.sprite = moon_6;
        }
        else if(timer>=originalTimer *14/21){
            spriterenderer.sprite = moon_7;
        }
        else if(timer>=originalTimer *13/21){
            spriterenderer.sprite = moon_8;
        }
        else if(timer>=originalTimer *12/21){
            spriterenderer.sprite = moon_hour12;
        }
        else if(timer>=originalTimer *11/21){
            spriterenderer.sprite = moon_hour1;
        }
        else if(timer>=originalTimer *10/21){
            spriterenderer.sprite = moon_hour2;
        }
        else if(timer>=originalTimer *9/21){
            spriterenderer.sprite = moon_hour3;
        }
        else if(timer>=originalTimer *8/21){
            spriterenderer.sprite = moon_hour4;
        }
        else if(timer>=originalTimer *7/21){
            spriterenderer.sprite = moon_hour5;
        }
        else if(timer>=originalTimer *6/21){
            spriterenderer.sprite = moon_hour6;
        }
        else if(timer>=originalTimer *5/21){
            spriterenderer.sprite = moon_hour7;
        }
        else if(timer>=originalTimer *4/21){
            spriterenderer.sprite = moon_hour8;
        }
        else if(timer>=originalTimer *3/21){
            spriterenderer.sprite = moon_hour9;
        }
        else if(timer>=originalTimer *2/21){
            spriterenderer.sprite = moon_hour10;
        }
        else if(timer>=originalTimer *1/21){
            spriterenderer.sprite = moon_hour11;
        }
        else{
            spriterenderer.sprite = moon_hour12;
        }
    }

    void UpdateTimer()
    {
        timer-=Time.deltaTime;
    }

    public float getTimer()
    {
        return timer;
    }

    public void reduceTimer(float reduceAmount)
    {
        timer -= reduceAmount;
    }
}
