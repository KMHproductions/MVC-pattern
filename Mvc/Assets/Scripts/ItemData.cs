using UnityEngine;

[CreateAssetMenu(fileName = "New Menu", menuName = "Menu")] //��� �������� �������� �� ����
public class ItemData : ScriptableObject
{
    public string menuName;//���� ����(���)   
    public string menuComposition;//������ ����
    public Sprite menuIcon; //������  
}


