using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject popupWindow1; // النافذة الأولى
    public GameObject popupWindow2; // النافذة الثانية

    void Start()
    {
        if (popupWindow1 != null)
            popupWindow1.SetActive(true); // النافذة الأولى تبدأ ظاهرة

        if (popupWindow2 != null)
            popupWindow2.SetActive(false); // النافذة الثانية تبدأ مخفية
    }

    // دالة عند الضغط على "ابدأ اللعب" لإخفاء الأولى وإظهار الثانية
    public void StartGame()
    {
        if (popupWindow1 != null)
            popupWindow1.SetActive(false); // إخفاء النافذة الأولى

        if (popupWindow2 != null)
            popupWindow2.SetActive(true); // إظهار النافذة الثانية
    }

    // دالة عند الضغط على "إلغاء" في popupWindow2 لإعادة popupWindow1
    public void CancelGame()
    {
        if (popupWindow2 != null)
            popupWindow2.SetActive(false); // إخفاء النافذة الثانية

        if (popupWindow1 != null)
            popupWindow1.SetActive(true); // إعادة إظهار النافذة الأولى
    }
}
