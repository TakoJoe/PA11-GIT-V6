using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Text TimeLeft;
    public static gameManager GM;
    public int score;
    public static int health = 5;
    public Text HealthLeft;
    public static int EnemyLevel = 1;
    public static float EnemyHealth = 15;
    public static int damage = 1;
    public int Exp = 0;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        GM = GetComponent<gameManager>();

        //GameObject Skeletal = GameObject.Find("Skeleton Spear_0");
        //Enemy enemy = Skeletal.GetComponent<Enemy>();

    }

    // Update is called once per frame
    void Update()
    {
        Score.text = ("Score: " + score);


        //if (Input.GetKey(KeyCode.P))
        //{
        //    timer = 0;
        //}

    }

}
