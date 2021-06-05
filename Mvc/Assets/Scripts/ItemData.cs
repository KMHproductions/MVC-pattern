using UnityEngine;

[CreateAssetMenu(fileName = "New Menu", menuName = "Menu")] //для создания элемента из меню
public class ItemData : ScriptableObject
{
    public string menuName;//поля меню(имя)   
    public string menuComposition;//состав меню
    public Sprite menuIcon; //спрайт  
}


