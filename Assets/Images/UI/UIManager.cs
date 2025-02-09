using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject board;

    public void StartGame()
    {
        settingsPanel.SetActive(false); // ÅÎİÇÁ ÇáÅÚÏÇÏÇÊ
        board.SetActive(true); // ÅÙåÇÑ ÇáÈæÑÏ
    }
}
