using UnityEngine;

public class GateController : MonoBehaviour
{
    public KeyCode openKey = KeyCode.U; // ������� ��� �������� �����
    public Animator gateAnimator; // ������ �� ��������� ��������� �����

    private bool isOpen = false; // ����, ������������, ������� �� ������

    void Update()
    {
        // ���������, ������ �� ������� ��� �������� �����
        if (Input.GetKeyDown(openKey))
        {
            // ���� ������ �������, ��������� ��
            if (!isOpen)
            {
                OpenGate();
            }
            // ���� ������ �������, ��������� ��
            else
            {
                CloseGate();
            }
        }
    }

    void OpenGate()
    {
        // ��������� �������� �������� �����
        gateAnimator.SetBool("isOpen", true);
        isOpen = true;
    }

    void CloseGate()
    {
        // ��������� �������� �������� �����
        gateAnimator.SetBool("isOpen", false);
        isOpen = false;
    }
}

