using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateCard : MonoBehaviour {

	[MenuItem ("Assets/Create/MyL/Card")]
    public static void CreateMyLCard()
    {
        MyLCard newCard = ScriptableObject.CreateInstance<MyLCard>();
        AssetDatabase.CreateAsset(newCard, "Assets/Resources/");
        AssetDatabase.SaveAssets();
    }
}
