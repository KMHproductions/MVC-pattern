using UnityEngine;

public class MVC_Model : MonoBehaviour
{
    public GameObject allMenu;    
    public GameObject menu_1;
    public GameObject menu_2;
    public GameObject menu_3;

    public float timeActiv;//����� ��������

    private void Start()
    {
        menu_1.SetActive(false);
        menu_2.SetActive(false);
        menu_3.SetActive(false);
    }

    void Update()
    {
        GetMenu();
    }

    public void GetMenu()//����� ���������� �������� ����
    {
        if (MVC_Controller.menu1)
        {
            Invoke("M1_active", timeActiv);           
        }

        if (MVC_Controller.menu2)
        {
            Invoke("M2_active", timeActiv);
        }

        if (MVC_Controller.menu3)
        {
            Invoke("M3_active", timeActiv);
        }
    }   

    public void M1_active()
    {
        menu_1.SetActive(true);
    }

    public void M2_active()
    {
        menu_2.SetActive(true);
    }

    public void M3_active()
    {
        menu_3.SetActive(true);
    }
}
