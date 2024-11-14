using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseCursorControl : MonoBehaviour
{
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
