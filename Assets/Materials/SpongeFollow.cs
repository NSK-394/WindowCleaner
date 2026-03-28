using UnityEngine;

public class SpongeFollow : MonoBehaviour
{
    void Update()
    {
        // 1. Get the 2D position of your mouse on the screen (Pixels)
        Vector3 mousePos = Input.mousePosition;
        
        // 2. Set the depth. 10 is the distance from the camera to the window.
        mousePos.z = 10f; 

        // 3. Convert that 2D screen point into a 3D point in the game world
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        // 4. Move this object (the Sponge) to that 3D position
        transform.position = worldPos;
    }
}