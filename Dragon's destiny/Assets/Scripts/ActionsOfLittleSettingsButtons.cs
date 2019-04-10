using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//для кнопок "помощь" и "вебсайт" в выпадающем меню настроек
public class ActionsOfLittleSettingsButtons : MonoBehaviour  
{
    
    public void OpenWebsite ()  //для кнопки "вебсайт"
    {
        Application.OpenURL("http://corazon.beget.tech/game/"); //открывается вебсайт
    }
    
}
