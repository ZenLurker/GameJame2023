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

    [SerializeField] float timer=0f;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        if(timer <= 15f){
            spriterenderer.sprite = moon_0;
        }
        if(timer>=15f && timer<= 30f){
            spriterenderer.sprite = moon_1;
        }
        if(timer>=30f && timer<= 45f){
            spriterenderer.sprite = moon_2;
        }
        if(timer>=45f && timer<= 60f){
            spriterenderer.sprite = moon_3;
        }
        if(timer>=60f && timer<= 75f){
            spriterenderer.sprite = moon_4;
        }
        if(timer>=75f && timer<= 90f){
            spriterenderer.sprite = moon_6;
        }
        if(timer>=90f && timer<= 105f){
            spriterenderer.sprite = moon_7;
        }
        if(timer>=105f && timer<= 120f){
            spriterenderer.sprite = moon_8;
        }
        if(timer>=120f && timer<= 125f){
            spriterenderer.sprite = moon_hour12;
        }
        if(timer>=125f && timer<= 130f){
            spriterenderer.sprite = moon_hour1;
        }
        if(timer>=130f && timer<= 135f){
            spriterenderer.sprite = moon_hour2;
        }
        if(timer>=135f && timer<= 140f){
            spriterenderer.sprite = moon_hour3;
        }
        if(timer>=140f && timer<= 145f){
            spriterenderer.sprite = moon_hour4;
        }
        if(timer>=145f && timer<= 150f){
            spriterenderer.sprite = moon_hour5;
        }
        if(timer>=150f && timer<= 155f){
            spriterenderer.sprite = moon_hour6;
        }
        if(timer>=155f && timer<= 160f){
            spriterenderer.sprite = moon_hour7;
        }
        if(timer>=160f && timer<= 165f){
            spriterenderer.sprite = moon_hour8;
        }
        if(timer>=165f && timer<= 170f){
            spriterenderer.sprite = moon_hour9;
        }
        if(timer>=170f && timer<= 175f){
            spriterenderer.sprite = moon_hour10;
        }
        if(timer>=175f && timer<= 180f){
            spriterenderer.sprite = moon_hour11;
        }
        if(timer>=180f && timer<= 185f){
            spriterenderer.sprite = moon_hour12;
        }
    }

    void UpdateTimer()
    {
        timer+=Time.deltaTime;
    }
}
