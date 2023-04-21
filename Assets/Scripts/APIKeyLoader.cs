using UnityEngine;
using System.IO;

public class APIKeyLoader : MonoBehaviour
{
    public static string apiKey;

    void Awake()
    {
        LoadApiKey();
        Debug.Log("API Key: " + apiKey);
    }

    private void LoadApiKey()
    {
        string configPath = Path.Combine(Application.dataPath, "../Assets/config.json");
        if (File.Exists(configPath))
        {
            string json = File.ReadAllText(configPath);
            ConfigData configData = JsonUtility.FromJson<ConfigData>(json);
            apiKey = configData.OpenApiKey;
        }
        else
        {
            Debug.LogError("Config file not found at " + configPath);
        }
    }
}

[System.Serializable]
public class ConfigData
{
    public string OpenApiKey;
}