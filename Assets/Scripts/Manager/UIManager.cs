using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public InputField mInputField;
    public Text mText;
    
    public void OnOK()
    {
        ConnectChatGPT.Instance.RequestData(mInputField.text, OnResult);
    }

    private void OnResult(Response result)
    {
        mText.text = result.GetText;
    }
}
