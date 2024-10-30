using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float red = 0.0f;
    public float green = 0.0f;
    public float blue = 0.0f;
    public bool colorsCycled = false;
    public bool hasPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        hasPressed = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        //colorCycle();
        transform.Rotate(0f, 1.0f, 0f, Space.Self);

        if (hasPressed)
        {
            if (!colorsCycled)
            {
                if (!(red >= 1.0f))
                {
                    red += 1.0f * Time.deltaTime;
                }
                else
                {
                    if (!(green >= 1.0f))
                    {
                        green += 1.0f * Time.deltaTime;
                    }
                    else
                    {
                        if (!(blue >= 1.0f))
                        {
                            blue += 1.0f * Time.deltaTime;
                        }
                    }
                }
                if ((red >= 1.0f) && (green >= 1.0f) && (blue >= 1.0f))
                {
                    colorsCycled = true;
                }
            }
            else
            {
                if (!(red <= 0.0f))
                {
                    red -= 1.0f * Time.deltaTime;
                }
                else
                {
                    if (!(green <= 0.0f))
                    {
                        green -= 1.0f * Time.deltaTime;
                    }
                    else
                    {
                        if (!(blue <= 0.0f))
                        {
                            blue -= 1.0f * Time.deltaTime;
                        }
                    }
                }
                if ((red <= 0.0f) && (green <= 0.0f) && (blue <= 0.0f))
                {
                    colorsCycled = false;
                }
            }
        GetComponent<MeshRenderer>().material.color = new Color(red, green, blue);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Destroy(gameObject);
    }


    //private void colorCycle()
    //{
    //    if (hasPressed)
    //    {
    //        if (!colorsCycled)
    //        {
    //            if (!(red >= 1.0f))
    //            {
    //                red += 1.0f * Time.deltaTime;
    //            }
    //            else
    //            {
    //                if (!(green >= 1.0f))
    //                {
    //                    green += 1.0f * Time.deltaTime;
    //                }
    //                else
    //                {
    //                    if (!(blue >= 1.0f))
    //                    {
    //                        blue += 1.0f * Time.deltaTime;
    //                    }
    //                }
    //            }
    //            if ((red >= 1.0f) && (green >= 1.0f) && (blue >= 1.0f))
    //            {
    //                colorsCycled = true;
    //            }
    //        }
    //        else
    //        {
    //            if (!(red <= 0.0f))
    //            {
    //                red -= 1.0f * Time.deltaTime;
    //            }
    //            else
    //            {
    //                if (!(green <= 0.0f))
    //                {
    //                    green -= 1.0f * Time.deltaTime;
    //                }
    //                else
    //                {
    //                    if (!(blue <= 0.0f))
    //                    {
    //                        blue -= 1.0f * Time.deltaTime;
    //                    }
    //                }
    //            }
    //            if ((red <= 0.0f) && (green <= 0.0f) && (blue <= 0.0f))
    //            {
    //                colorsCycled = false;
    //            }
    //        }
    //    }
    //    GetComponent<MeshRenderer>().material.color = new Color(red, green, blue);
    //}
}
