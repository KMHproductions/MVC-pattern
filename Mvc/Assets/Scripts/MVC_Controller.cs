using UnityEngine;
using UnityEngine.SceneManagement;

public class MVC_Controller : MonoBehaviour
{      
    public static bool menu1 = false;//статичная переменная
    public static bool menu2 = false;
    public static bool menu3 = false;

    public void ButtonMenu_1_WasCliked()//метож нажатия на кнопку
    {
        menu1 = true;
    }

    public void ButtonMenu_2_WasCliked()
    {
        menu2 = true;
    }

    public void ButtonMenu_3_WasCliked()
    {
        menu3 = true;
    }

    public void RestartMainScene()//метод рестарт уровня
    {
        SceneManager.LoadScene("MainScene");
    }

    void Start()
    {
        menu1 = false;
        menu2 = false;
        menu3 = false;
    }
}
