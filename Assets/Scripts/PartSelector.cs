using UnityEngine;

public class PartSelector : MonoBehaviour
{
    public Sprite[] parts;
    private SpriteRenderer partRenderer;
    void Awake()
    {
        partRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        partRenderer.sprite = parts[1];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
