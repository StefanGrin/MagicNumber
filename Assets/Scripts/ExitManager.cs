using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
