using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script123Test : MonoBehaviour {

    [SerializeField]
    public Text TextField = null;
    public Text NumberField = null;


    public float standardPassingByTime;


	// Use this for initialization
	void Start () {

     


    }
	
	// Update is called once per frame
	void Update () {


        standardPassingByTime = standardPassingByTime - Time.deltaTime;


        if(standardPassingByTime < 5)
        {
            TextField.text = "This is a Sombrero or a Pill on a Plate!";
            if (standardPassingByTime < 0)
            {
                standardPassingByTime = 10;
            }
           
        }
        if(standardPassingByTime > 5)
        {
            TextField.text = "RamboMambo";


        }


        NumberField.text = standardPassingByTime.ToString();





    }
}
