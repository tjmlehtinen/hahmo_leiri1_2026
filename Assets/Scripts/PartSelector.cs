using UnityEngine;

public class PartSelector : MonoBehaviour
{
    public Sprite[] parts;
    private SpriteRenderer partRenderer;
    private int currentIndex = 0;
    void Awake()
    {
        partRenderer = GetComponent<SpriteRenderer>();
    }
    public void NextPart()
    {
        currentIndex = (currentIndex + 1) % parts.Length;
        partRenderer.sprite = parts[currentIndex];
    }
    public void PreviousPart()
    {
        currentIndex = currentIndex - 1;
        if (currentIndex < 0)
        {
            currentIndex = currentIndex + parts.Length;
        }
        partRenderer.sprite = parts[currentIndex];
    }
    public void SetColor(Color color)
    {}
}
