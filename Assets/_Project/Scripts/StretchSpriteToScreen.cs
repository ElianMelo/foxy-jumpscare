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

        //Vector2 spriteSize = sr.sprite.bounds.size;

        //Debug.Log(spriteSize.x);
        //Debug.Log(spriteSize.y);

        transform.localScale = new Vector3(
            screenWidth / 10.25f,
            screenHeight / 7.69f,
            1f
        );

        // sr.sprite = null;
    }
}