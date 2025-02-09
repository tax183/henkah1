using UnityEngine;
using UnityEngine.SceneManagement; // مهم لتحميل المشاهد

public class SceneLoader : MonoBehaviour
{
    // هذه الدالة سيتم استدعاؤها عند الضغط على الزر
    public void goToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // تحميل المشهد المطلوب
    }

    // ✅ دالة لتحميل مشهد "Games page" مباشرةً
    public void GoToGamesPage()
    {
        SceneManager.LoadScene("Games page"); 
    }

}
