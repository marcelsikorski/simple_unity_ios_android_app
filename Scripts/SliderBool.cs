using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderBool : MonoBehaviour 
{
    public GameObject Panel;

    public void Openpanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

}
