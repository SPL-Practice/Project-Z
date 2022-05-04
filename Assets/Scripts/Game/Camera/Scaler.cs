using UnityEngine;

public class Scaler : MonoBehaviour
{
    public bool scaleProportions;
    public bool scalePosition;

    internal void Awake()
    {
        Transform current = gameObject.transform;

        if (scaleProportions)
            ScaleProportions(current);
        if (scalePosition)
            ScalePosition(current);
    }

    private void ScaleProportions(Transform current)
    {
        float w = current.localScale.x;
        float h = current.localScale.y;

        current.localScale = new Vector2(w, h * Screen.height / 720);
    }

    private void ScalePosition(Transform current)
    {
        float x = current.position.x;
        float y = current.position.y;

        current.position = new Vector2(x * Screen.width / 1280, y * Screen.height / 720);
    }
}