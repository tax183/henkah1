using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public static int DEFAULT_NUMBER_OF_FIELDS = 24; // عدد المربعات الافتراضي

    [SerializeField] private GameObject fieldPrefab;  // مرجع إلى الـ Prefab الخاص بالمربعات
    [SerializeField] private Transform boardContainer; // اللوحة التي سيتم وضع المربعات داخلها (BoardPanel)

    private List<Field> fields = new List<Field>(); // تخزين المربعات
  

    void Start()
    {
        GenerateBoard(); // عند بدء اللعبة، يتم إنشاء المربعات
                         // البحث عن الكائنات تلقائيًا داخل المشهد
        fieldPrefab = GameObject.Find("FieldButton");
        boardContainer = GameObject.Find("BoardPanel").transform;

        if (fieldPrefab == null || boardContainer == null)
        {
            Debug.LogError("لم يتم العثور على FieldPrefab أو BoardContainer في المشهد!");
            return;
        }

        GenerateBoard();
    }

    void GenerateBoard()
    {
        for (int i = 0; i < DEFAULT_NUMBER_OF_FIELDS; i++)
        {
            // إنشاء مربع جديد باستخدام Prefab
            GameObject fieldGO = Instantiate(fieldPrefab, boardContainer);

            // ضبط اسم المربع ليكون "Field 1", "Field 2", ...
            fieldGO.name = "Field " + (i + 1);

            // تخزين المربع في القائمة
            fields.Add(new Field(i));

            // إضافة حدث النقر على الزر
            int fieldIndex = i; // تجنب مشكلة الـ Closure
            fieldGO.GetComponent<Button>().onClick.AddListener(() => OnFieldClick(fieldIndex));
        }
    }

    void OnFieldClick(int index)
    {
        Debug.Log("تم النقر على المربع: " + index);
        // يمكنك تغيير لون الزر عند النقر عليه
        boardContainer.GetChild(index).GetComponent<Button>().image.color = Color.red;
    }
}
