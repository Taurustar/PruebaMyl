using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapScript : MonoBehaviour {

    string url;
    string geoKey = "&key=AIzaSyA6zF9_mD6H7gcRsTephnXF7_SVixuaeAE";
    public GeoScript geo;
    public RawImage Map;

    public void ShowMap()
    {
        if (geo.latitude == null || geo.longitude == null)
        {
            //TODO: No Coordinates
        }
        else
        {
            url = "https://maps.googleapis.com/maps/api/staticmap?center=" + geo.latitude + "," + geo.longitude + "&size=384x384&zoom=16&markers=color:red%7Clabel:A%7C" + geo.latitude + "," + geo.longitude + "&key=AIzaSyA6zF9_mD6H7gcRsTephnXF7_SVixuaeAE";
            StartCoroutine(RequestMap());
        }
    }

    public IEnumerator RequestMap()
    {
        WWW www = new WWW(url);
        yield return www;
        yield return new WaitUntil(() => www.isDone);

        Map.texture = www.texture;
    }
}
