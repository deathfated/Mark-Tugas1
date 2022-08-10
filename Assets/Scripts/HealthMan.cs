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
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(true);
                h3.gameObject.SetActive(true);
                h4.gameObject.SetActive(true);
                h5.gameObject.SetActive(true);
                break;
            case 4:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(true);
                h3.gameObject.SetActive(true);
                h4.gameObject.SetActive(true);
                h5.gameObject.SetActive(false);
                break;
            case 3:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(true);
                h3.gameObject.SetActive(true);
                h4.gameObject.SetActive(false);
                h5.gameObject.SetActive(false);
                break;
            case 2:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(true);
                h3.gameObject.SetActive(false);
                h4.gameObject.SetActive(false);
                h5.gameObject.SetActive(false);
                break;
            case 1:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(false);
                h3.gameObject.SetActive(false);
                h4.gameObject.SetActive(false);
                h5.gameObject.SetActive(false);
                break;

            case 0:
                h1.gameObject.SetActive(false);
                h2.gameObject.SetActive(false);
                h3.gameObject.SetActive(false);
                h4.gameObject.SetActive(false);
                h5.gameObject.SetActive(false);
                break;
        }
    }
}
