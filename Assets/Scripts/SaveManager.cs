using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public PartSelector hair;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadCharacter();
    }

    public void SaveCharacter()
    {
        SavePart(hair, "hair");
    }
    public void LoadCharacter()
    {
        LoadPart(hair, "hair");
    }

    private void SavePart(PartSelector part, string id)
    {
        PlayerPrefs.SetInt(id + "index", part.GetIndex());
        string colorString = ColorUtility.ToHtmlStringRGB(part.GetColor());
        PlayerPrefs.SetString(id + "color", colorString);
    }
    private void LoadPart(PartSelector part, string id)
    {
        part.SetIndex(PlayerPrefs.GetInt(id + "index", 0));
        string colorString = PlayerPrefs.GetString(id + "color", "FFFFFF");
        if (ColorUtility.TryParseHtmlString("#" + colorString, out Color color))
        {
            part.SetColor(color);
        }
    }
}
