using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Winner : MonoBehaviour
{   
    public GameObject panel1, panel2, panel3;
    [SerializeField] public TextMeshPro winner;


    void Start()
    {
      winner.text = "";
    }

    void Update()
    {
        var color1 = panel1.GetComponent<Renderer>().material.color;
        var color2 = panel2.GetComponent<Renderer>().material.color;
        var color3 = panel3.GetComponent<Renderer>().material.color;
        winner.text = "Turn the solar panels to face the sun.";

        if (color1 == color2 && color2 == color3)
        {
            Debug.Log("YEEEEET");
            winner.text = "You did it!";       
        }
    }

    
}
