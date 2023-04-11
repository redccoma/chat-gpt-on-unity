using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_InputField mInputField;
    public TMP_Text mText;
    
    public void OnOK()
    {
        ConnectChatGPT.Instance.RequestData(mInputField.text, OnResult);
    }

    private void OnResult(Response result)
    {
        mText.text = result.GetText;
    }
}
