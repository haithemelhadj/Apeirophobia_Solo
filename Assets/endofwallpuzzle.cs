using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endofwallpuzzle : MonoBehaviour
{
    public GameObject UI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UI.SetActive(false);
        }
    }
}
