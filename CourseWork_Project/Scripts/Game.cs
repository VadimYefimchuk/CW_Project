using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public Material wallMaterial;

    public static int points;

    public int countWals = 20;

    private string _pointsString;
    private int _lastPonts = -1;

    public void Awake()
    {
        points = 0;

        Food.GenerateNewFood();
    }

    public void Update()
    {
        if (_lastPonts == points) return;

        _lastPonts = points;
        _pointsString = "Рахунок: " + points.ToString("0000");
    }



    public void OnGUI()
    {
        GUI.color = Color.white;
        GUI.Label(new Rect(20, 20, 200, 20), _pointsString ?? "");
    }

}


