using UnityEngine.SceneManagement;

namespace COMP397
{
    public class SceneController : Singleton<SceneController>
    {
        public void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
