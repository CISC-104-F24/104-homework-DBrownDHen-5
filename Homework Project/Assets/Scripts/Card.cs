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

    public Sprite heart;
    public Sprite diamond;
    public Sprite club;
    public Sprite spade;


    // Start is called before the first frame update
    void Start()
    {
        background.color = bgColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeNumber(1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeNumber(-1);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeSuit();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RandomizeBackground();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBackground();
        }
    }

    public void ChangeNumber(int number)
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

    public void RandomizeBackground()
    {
        float randomRed = Random.Range(0.0f, 1.0f);
        float randomGreen = Random.Range(0.0f, 1.0f);
        float randomBlue = Random.Range(0.0f, 1.0f);
        currentColor = new Color(randomBlue, randomGreen, randomRed);
        background.color = currentColor;
    }

    public void ResetBackground()
    {
        background.color = bgColor;
        currentColor = bgColor;
    }

    public void ChangeSuit()
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
            suitIcon.sprite = heart;
        }
        else if (suit == 2)
        {
            suitIcon.sprite = diamond;
        }
        else if (suit == 3)
        {
            suitIcon.sprite = club;
        }
        else if (suit == 4)
        {
            suitIcon.sprite = spade;
        }
    }
}
