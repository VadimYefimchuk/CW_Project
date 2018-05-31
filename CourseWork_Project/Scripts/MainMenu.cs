using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Vector2 SizeMenu = new Vector2(500, 300);

    public float MinHeightButton = 60f;
    public Font FontСaption;
    public Font FontButton;

    // текст меню
    public string MenuText = "Меню";
    public string StartText = "Почати Гру";
    public string ExitText = "Вийти з Гри";

    public void OnGUI()
    {

        Rect rect = new Rect(
            Screen.width / 2f - SizeMenu.x / 2,
            Screen.height / 2f - SizeMenu.y / 2,
            SizeMenu.x,
            SizeMenu.y);

        GUILayout.BeginArea(rect, GUI.skin.textArea);
        {

            GUIStyle captionStyle = new GUIStyle(GUI.skin.label);

            captionStyle.font = FontСaption;

            captionStyle.alignment = TextAnchor.MiddleCenter;

            GUILayout.Label(MenuText, captionStyle);

            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);

            buttonStyle.font = FontButton;

            buttonStyle.margin = new RectOffset(20, 20, 3, 3);

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(StartText, buttonStyle, GUILayout.MinHeight(MinHeightButton)))
            {
                SceneManager.LoadScene(1);
            }


            GUILayout.FlexibleSpace(); 

            if (GUILayout.Button(ExitText, buttonStyle, GUILayout.MinHeight(MinHeightButton)))
            {
                Application.Quit();
            }

            GUILayout.FlexibleSpace(); 

        }
        GUILayout.EndArea();

    }
}


