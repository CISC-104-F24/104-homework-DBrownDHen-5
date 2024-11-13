using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    public int num = 1;
    public Color bgColor = new Color(0.698039216f, 0.698039216f, 0.698039216f);
    public Color currentColor;
    public int suit = 1;

    public TextMeshProUGUI topNum;
    public TextMeshProUGUI bottomNum;
    public Image background;
    public Image suitIcon;


    // Start is called before the first frame update
    void Start()
    {
        background.color = bgColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeNumber(int number)
    {
        if (number < 0)
        {
            if (num != 1)
            {
                num += number;
            }
        }
        else
        {
            if (num != 99)
            {
                num += number;
            }
        }
        topNum.text = num.ToString();
        bottomNum.text = num.ToString();
    }

    public void randomizeBackground()
    {
        float randomRed = Random.Range(0.0f, 1.0f);
        float randomGreen = Random.Range(0.0f, 1.0f);
        float randomBlue = Random.Range(0.0f, 1.0f);
        currentColor = new Color(randomBlue, randomGreen, randomRed);
        background.color = currentColor;
    }

    public void resetBackground()
    {
        background.color = bgColor;
    }

    public void changeSuit()
    {
        if (suit != 4)
        {
            suit++;
        }
        else
        {
            suit = 1;
        }

        // The card's suit will be changed depending on the value stored in "suit" (1, 2, 3, or 4)

        if (suit == 1)
        {
            suitIcon.sprite = idk?;
        }
        else if (suit == 2)
        {

        }
        else if (suit == 3)
        {

        }
        else if (suit == 4)
        {

        }
    }
}
