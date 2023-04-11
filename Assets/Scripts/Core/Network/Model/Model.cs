using Newtonsoft.Json;
using System.Collections.Generic;

public class Response
{
    public OpenAI_Response result;

    public Response(OpenAI_Response _result)
    {
        result = _result;
    }

    public bool IsSuccess { get { return result != null; } }
    public string GetText { get { return IsSuccess ? result.choices[0].text : "Response Error."; } }
}

/// <summary>
/// openai API Response 데이터
/// </summary>
[System.Serializable]
public class OpenAI_Response
{
    public string id;
    
    [JsonProperty("object")]
    public string objectName;

    public string created;

    public string model;

    public List<OpenAI_Choices> choices;

    public OpenAI_Usage usage;
}

[System.Serializable]
public class OpenAI_Choices
{
    public string text;
    public int index;
    public bool? logprobs;
    public string finish_reason;
}

[System.Serializable]
public class OpenAI_Usage
{
    public int prompt_tokens;
    public int completion_tokens;
    public int total_tokens;
}