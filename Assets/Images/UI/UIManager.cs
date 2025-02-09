using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject board;

    public void StartGame()
    {
        settingsPanel.SetActive(false); // ����� ���������
        board.SetActive(true); // ����� ������
    }
}
