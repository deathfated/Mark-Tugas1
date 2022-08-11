using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMan : MonoBehaviour
{

    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public GameObject h4;
    public GameObject h5;

    public void ChangeHealth(int health)
    {
        switch (health)
        {

            case 5:
                break;
            case 4:
                h5.SetActive(false);
                break;
            case 3:

                h4.SetActive(false);
                h5.SetActive(false);
                break;
            case 2:
                h3.SetActive(false);
                h4.SetActive(false);
                h5.SetActive(false);
                break;
            case 1:
                h2.SetActive(false);
                h3.SetActive(false);
                h4.SetActive(false);
                h5.SetActive(false);
                break;
            case 0:
                h1.SetActive(false);
                h2.SetActive(false);
                h3.SetActive(false);
                h4.SetActive(false);
                h5.SetActive(false);
                break;
        }
    }
}
