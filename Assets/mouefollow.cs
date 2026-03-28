using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public bool canMove = false;

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 targetPos = new Vector3(worldPos.x, 0.5f, worldPos.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 10f);
    }
}