using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSwapper : MonoBehaviour {

    public GameObject[] vehicles;
    public GameObject[] sunLights;
    public int vehicleIndex = 0;
    public int sunIndex = 0;
    public Material[] skyMaterials;


    void Start()
    {
        vehicles[vehicleIndex].SetActive(true);
        sunLights[sunIndex].SetActive(true);
        RenderSettings.skybox = skyMaterials[sunIndex];
        if (sunIndex == 1 || sunIndex == 3)
        {
            RenderSettings.fog = true;

        }
        else
        {
            RenderSettings.fog = false;
        }
        RenderSettings.sun = sunLights[sunIndex].GetComponent<Light>();
    }

	public void ChangeVehicleNext()
    {
        vehicles[vehicleIndex].SetActive(false);
        vehicleIndex++;
        if(vehicleIndex >= vehicles.Length)
        {
            vehicleIndex = 0;
        }
        if (vehicleIndex < 0)
        {
            vehicleIndex = vehicles.Length - 1;
        }

        vehicles[vehicleIndex].SetActive(true);
    }
    public void ChangeVehiclePrev()
    {
        vehicles[vehicleIndex].SetActive(false);
        vehicleIndex--;
        if (vehicleIndex >= vehicles.Length)
        {
            vehicleIndex = 0;
        }
        if (vehicleIndex < 0)
        {
            vehicleIndex = vehicles.Length - 1;
        }
        vehicles[vehicleIndex].SetActive(true);
    }








    public void ChangeSceneNext()
    {
        sunLights[sunIndex].SetActive(false);
        
        sunIndex++;
        if (sunIndex >= sunLights.Length)
        {
            sunIndex = 0;
        }
        if (sunIndex < 0)
        {
            sunIndex = sunLights.Length - 1;
        }

        sunLights[sunIndex].SetActive(true);
        RenderSettings.skybox = skyMaterials[sunIndex];
        if(sunIndex == 1)
        {
            RenderSettings.fog = true;
            
        }
        else
        {
            RenderSettings.fog = false;
        }

        if(sunIndex == 0)
        {
            foreach(GameObject go in GameObject.FindGameObjectsWithTag("Lights"))
            {
                go.GetComponent<Light>().enabled = false;
            }
        }
        else
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Lights"))
            {
                go.GetComponent<Light>().enabled = true;
            }
        }
        RenderSettings.sun = sunLights[sunIndex].GetComponent<Light>();
    }
    
}
