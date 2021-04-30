using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoothController : MonoBehaviour
{
    private GameObject panels1;
    private GameObject panels2;
    private GameObject panels3;
    private GameObject panels4;
    private GameObject panels5;

    public GameObject booths1;
    public GameObject booths2;
    public GameObject booths3;
    public GameObject booths4;
    public GameObject booths5;

    public bool isOpen1;
    public bool isOpen2;
    public bool isOpen3;
    public bool isOpen4;
    public bool isOpen5;



    private void Update()
    {

        


        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (Physics2D.Raycast(mousePos, Vector2.zero))
            {
                if (hit.transform != null)
                {
                    GameObject gameObject = hit.transform.gameObject;

                    if (gameObject.name == "Booth1")
                    {
                        

                        if (isOpen1 == true)
                        {
                            isOpen1 = false;
                            panels1.transform.GetChild(0).gameObject.SetActive(false);
                            panels1.transform.GetChild(1).gameObject.SetActive(false);
                        } else
                        {
                            isOpen1 = true;
                            panels1.transform.GetChild(0).gameObject.SetActive(true);
                            panels1.transform.GetChild(1).gameObject.SetActive(true);
                        }
                    } else if (gameObject.name == "Booth2")
                    {
                        if (isOpen2 == true)
                        {
                            isOpen2 = false;
                            panels2.transform.GetChild(0).gameObject.SetActive(false);
                            panels2.transform.GetChild(1).gameObject.SetActive(false);
                        }
                        else
                        {
                            isOpen2 = true;
                            panels2.transform.GetChild(0).gameObject.SetActive(true);
                            panels2.transform.GetChild(1).gameObject.SetActive(true);
                        }
                    } else if (gameObject.name == "Booth3")
                    {
                        if (isOpen3 == true)
                        {
                            isOpen3 = false;
                            panels3.transform.GetChild(0).gameObject.SetActive(false);
                            panels3.transform.GetChild(1).gameObject.SetActive(false);
                        }
                        else
                        {
                            isOpen3 = true;
                            panels3.transform.GetChild(0).gameObject.SetActive(true);
                            panels3.transform.GetChild(1).gameObject.SetActive(true);
                        }
                    } else if (gameObject.name == "Booth4")
                    {
                        if (isOpen4 == true)
                        {
                            isOpen4 = false;
                            panels4.transform.GetChild(0).gameObject.SetActive(false);
                            panels4.transform.GetChild(1).gameObject.SetActive(false);
                        }
                        else
                        {
                            isOpen4 = true;
                            panels4.transform.GetChild(0).gameObject.SetActive(true);
                            panels4.transform.GetChild(1).gameObject.SetActive(true);
                        }
                    } else if (gameObject.name == "Booth5")
                    {
                        if (isOpen5 == true)
                        {
                            isOpen5 = false;
                            panels5.transform.GetChild(0).gameObject.SetActive(false);
                            panels5.transform.GetChild(1).gameObject.SetActive(false);
                        }
                        else
                        {
                            isOpen5 = true;
                            panels5.transform.GetChild(0).gameObject.SetActive(true);
                            panels5.transform.GetChild(1).gameObject.SetActive(true);
                        }
                    }

                }
            }
        }

    }




    private void Start()
    {
        panels1 = GameObject.Find("projectCanvas1");
        panels2 = GameObject.Find("projectCanvas2");
        panels3 = GameObject.Find("projectCanvas3");
        panels4 = GameObject.Find("projectCanvas4");
        panels5 = GameObject.Find("projectCanvas5");

    }



}
