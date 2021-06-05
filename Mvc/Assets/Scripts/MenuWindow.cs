using UnityEngine;
using UnityEngine.UI;

public class MenuWindow : MonoBehaviour
{
    public ItemData menuData;//������ �� ������� �� ��

    public Image imageMenu;
    public Text compositionMenu;

    private void Update()
    {
        DrawMenu();
    }

    public void DrawMenu()//��������� �������� �� ��
    {
        imageMenu.sprite = menuData.menuIcon;
        compositionMenu.text = menuData.menuComposition;
    }
}

