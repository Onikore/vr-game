using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PassportData : MonoBehaviour
{
    public Font globalFont;
    
    [Range(1,100)]
    public int globalFontSize;
    
    public TextField[] textFields;

    void Start()
    {
        foreach (var i in textFields)
        {
            var tmp = gameObject.AddComponent<TextMeshPro>();
            tmp.text = i.text;
            tmp.fontSize = i.fontSize;
            tmp.font = i.font;
        }
    }

    void Update()
    {
    }
}

[Serializable]
public class TextField
{
    public string text;
    public Vector3 textPosition;
    public TMP_FontAsset font;

    [Range(1,100)]
    public int fontSize;
}