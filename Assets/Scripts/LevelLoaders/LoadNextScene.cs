using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextSceney()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
