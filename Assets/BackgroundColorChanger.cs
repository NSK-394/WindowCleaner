using UnityEngine;

public class BackgroundColorChanger : MonoBehaviour
{
    public void SetToWhite()
    {
        Camera.main.backgroundColor = Color.white;
    }
}