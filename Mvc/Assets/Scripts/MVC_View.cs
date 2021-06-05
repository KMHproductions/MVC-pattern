using UnityEngine;//����������� ����������
using UnityEngine.UI;

public class MVC_View : MonoBehaviour
{
    public GameObject userUses;//�������� �������
    public GameObject manipulates;
    public GameObject updates;
    public GameObject userSeesAfterUpdates;
    public Text message;//�������� ���������� ����

    private void Start()//����� ���������� 1 ��� ��� ������
    {
        userUses.SetActive(false);//����������� �������
        manipulates.SetActive(false);
        updates.SetActive(false);
        userSeesAfterUpdates.SetActive(false);
        message.text = "User sees...";//���������� ���������� ����
}
    private void Update()//����� ����������� ������ ����
    {
        See();
    }

    public void See()//��������� ����� ����������
    {
        if (MVC_Controller.menu1 || MVC_Controller.menu2 || MVC_Controller.menu3)
        {
            Invoke("See1", 1f);//����� ��������� ��������
            Invoke("See2", 4f);
            Invoke("See3", 7f);
            Invoke("See4", 10f);
        }
    }
    public void See1()//���������� ���������� ����
    {
        userUses.SetActive(true);
        message.text = "User uses...";
    }
    public void See2()
    {
        manipulates.SetActive(true);
        message.text = "Manipulations(fastfood seller)";
    }
    public void See3()
    {
        updates.SetActive(true);
        message.text = "Updates(the chef is cooking)";
    }
    public void See4()
    {
        userSeesAfterUpdates.SetActive(true);
        message.text = "User sees after updates(get your order)";
    }
}
