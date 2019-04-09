using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject HelpingMenu; //выпадающее меню с кнопками для настроек

    //для кнопки "Settings" в сцене main
    public void ShowHelpSettings()
    {
        HelpingMenu.SetActive(!HelpingMenu.activeSelf); ////при нажатии на кнопку "настройки" выпадающее меню становится активным (видимым), если оно было выключено, и наоборот
    }
}
