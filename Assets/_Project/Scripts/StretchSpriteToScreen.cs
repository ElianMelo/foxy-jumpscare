using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class StretchSpriteToScreen : MonoBehaviour
{
    void Start()
    {
        Resize();
    }

    void Resize()
    {
        Camera cam = Camera.main;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        float screenHeight = cam.orthographicSize * 2f;
        float screenWidth = screenHeight * cam.aspect;

        Vector2 spriteSize = sr.sprite.bounds.size;

        transform.localScale = new Vector3(
            screenWidth / spriteSize.x,
            screenHeight / spriteSize.y,
            1f
        );
    }
}