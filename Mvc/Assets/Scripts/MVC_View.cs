using UnityEngine;//необходимые библиотеки
using UnityEngine.UI;

public class MVC_View : MonoBehaviour
{
    public GameObject userUses;//создание обьекта
    public GameObject manipulates;
    public GameObject updates;
    public GameObject userSeesAfterUpdates;
    public Text message;//создание текстового поля

    private void Start()//метод вызывается 1 раз при старте
    {
        userUses.SetActive(false);//диактивация обьекта
        manipulates.SetActive(false);
        updates.SetActive(false);
        userSeesAfterUpdates.SetActive(false);
        message.text = "User sees...";//заполнение текстового поля
}
    private void Update()//метод проверяется каждый кадр
    {
        See();
    }

    public void See()//реализует показ указателей
    {
        if (MVC_Controller.menu1 || MVC_Controller.menu2 || MVC_Controller.menu3)
        {
            Invoke("See1", 1f);//метод реализует задержку
            Invoke("See2", 4f);
            Invoke("See3", 7f);
            Invoke("See4", 10f);
        }
    }
    public void See1()//заполнение текстового поля
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
