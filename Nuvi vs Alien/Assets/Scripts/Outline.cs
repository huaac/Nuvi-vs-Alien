using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outline : MonoBehaviour
{

    public Slider num_of_enemies;

    public Transform[] positions;
    private Transform location;

    public GameObject opening_screen;
    public GameObject winner_screen;
    public GameObject enemy1;
    public GameObject player1;

    private bool is_generated;
    public int enemies_left;

    // Start is called before the first frame update
    void Start()
    {
        winner_screen.SetActive(false);
        is_generated = false;
        enemies_left = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(is_generated == false)
        {
            if (opening_screen.activeSelf == false)
            {
                generate();
                is_generated = true;
                enemies_left = (int) num_of_enemies.value;
            }
        }

        if(enemies_left == 0)
        {
            showEndScreen();
        }
    }
        
    private void generate()
    {
        for(int x = 1; x <= num_of_enemies.value; x++) //for each number of enemies wanted from the slider
        {
            location = positions[x];    //since it's an array, take transform from index x
            GameObject enemy = Instantiate(enemy1, location);   //instantiate enemy at chosen location
        }
        location = positions[0];
        GameObject player = Instantiate(player1, location);
    }

    private void showEndScreen()
    {
        winner_screen.SetActive(true);
    }
}
