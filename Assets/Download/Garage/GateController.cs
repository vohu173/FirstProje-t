using UnityEngine;

public class GateController : MonoBehaviour
{
    public KeyCode openKey = KeyCode.U; // Клавиша для открытия ворот
    public Animator gateAnimator; // Ссылка на компонент аниматора ворот

    private bool isOpen = false; // Флаг, показывающий, открыты ли ворота

    void Update()
    {
        // Проверяем, нажата ли клавиша для открытия ворот
        if (Input.GetKeyDown(openKey))
        {
            // Если ворота закрыты, открываем их
            if (!isOpen)
            {
                OpenGate();
            }
            // Если ворота открыты, закрываем их
            else
            {
                CloseGate();
            }
        }
    }

    void OpenGate()
    {
        // Запускаем анимацию открытия ворот
        gateAnimator.SetBool("isOpen", true);
        isOpen = true;
    }

    void CloseGate()
    {
        // Запускаем анимацию закрытия ворот
        gateAnimator.SetBool("isOpen", false);
        isOpen = false;
    }
}

