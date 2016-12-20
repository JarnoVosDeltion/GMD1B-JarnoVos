using UnityEngine;
using System.Collections;

public class CursorState : MonoBehaviour {

    public CursorLockMode startMode;

    void Start()
    {
        SetCursorState(startMode);
    }

    public void SetCursorState(CursorLockMode wantedMode)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = wantedMode;
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }
}