using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TextDataLoader : MonoBehaviour
{
    public TextMesh textMesh; // ������ �� ��������� TextMesh ��� ����������� ������

    private string jsonURL = "https://drive.google.com/uc?export=download&id=1FncfKq4rS4HWPvOJr7oJ4hKhmW0MMPK1";

    void Start()
    {
        StartCoroutine(GetTextData(jsonURL));
    }

    IEnumerator GetTextData(string url)
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.LogError(request.error);
        }
        else
        {
            // ������������, ��� JSON ���� �������� ������ ��������� ������
            string textData = request.downloadHandler.text;
            textMesh.text = textData;
        }
    }
}
