using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJson;

public class GeoScript : MonoBehaviour {

    string urlGeo = "https://maps.googleapis.com/maps/api/geocode/json?new_forward_geocoder=true&sensor=false&address=";
    string geoKey = "&key=AIzaSyA6zF9_mD6H7gcRsTephnXF7_SVixuaeAE";
    public string address;
    public string latitude, longitude;
    public InputField addressBox;

    public void SendGeoRequest()
    {
        address = addressBox.text;
        StartCoroutine(GeoRequest());
    }


    IEnumerator GeoRequest()
    {
        WWW www = new WWW(urlGeo + address + geoKey);
        yield return www;
        yield return new WaitUntil(()=> www.isDone);

        string requestJson = JSON.Parse(www.text);

        longitude = www.text;
        Debug.Log(www.text);
    }
}
