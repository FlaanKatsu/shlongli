using UnityEngine;

public class CursorLockExample : MonoBehaviour
{
    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.Space))
            Cursor.lockState = CursorLockMode.None;
    }

    void OnGUI()
    {
        //Press this button to lock the Cursor
        Cursor.lockState = CursorLockMode.Locked;

    }
}