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
    public Color GetColor()
    {
        return partRenderer.color;
    }
    public void SetColor(Color color)
    {
        partRenderer.color = color;
    }
    public int GetIndex()
    {
        return currentIndex;
    }
    public void SetIndex(int index)
    {
        currentIndex = index;
        partRenderer.sprite = parts[currentIndex];
    }
}
