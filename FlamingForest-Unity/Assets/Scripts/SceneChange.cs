using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void ChangeToScene (string TargetSceneName)
    {
        SceneManager.LoadScene (TargetSceneName);
    }
}
