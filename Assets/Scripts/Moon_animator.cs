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

    [SerializeField] Sprite[] moons;
    private int currentMoon = 0;

    public float timer;
    private float originalTimer = 30f;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        loadNextMoon();
        timer = originalTimer/21;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();

        if(timer < 0) {
            timer = originalTimer/21;
            currentMoon++;
            loadNextMoon();
        }


    }

    private void loadNextMoon() {
        if(currentMoon < moons.Length) {
            spriterenderer.sprite = moons[currentMoon];
        } else {
            originalTimer = 0;
        }
    }

    void UpdateTimer()
    {
        timer-=Time.deltaTime;
    }

    public float getTimer()
    {
        return originalTimer;
    }

    public void reduceTimer(float reduceAmount)
    {
        originalTimer -= reduceAmount;
    }
}
