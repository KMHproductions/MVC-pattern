using UnityEngine;
using UnityEngine.UI;

public class MenuWindow : MonoBehaviour
{
    public ItemData menuData;//ссылка на элемент из БД

    public Image imageMenu;
    public Text compositionMenu;

    private void Update()
    {
        DrawMenu();
    }

    public void DrawMenu()//отрисовка элемента из БД
    {
        imageMenu.sprite = menuData.menuIcon;
        compositionMenu.text = menuData.menuComposition;
    }
}

