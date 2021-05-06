using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLamp : MonoBehaviour
{
    public GameObject txtToDisplay;

    private bool Inside;

    private void OnTriggerEnter(Collider other)
    {
        Inside = true;

        if (other.gameObject.tag == "Player" && Inside == true)
        {
            txtToDisplay.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Inside = false;
        if (other.gameObject.tag == "Player" && Inside == false)
        {
            txtToDisplay.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

}
