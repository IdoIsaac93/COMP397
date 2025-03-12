using UnityEngine;
using UnityEngine.UI;

namespace COMP397
{
    public class GameOverController : MonoBehaviour
    {
        [SerializeField] private Button menuBtn;
        [SerializeField] private Button restartBtn;
        [SerializeField] private Button quitBtn;

        private void Start()
        {
            menuBtn.onClick.AddListener(() => {
                SceneController.Instance.ChangeScene("MainMenu");
                Debug.Log("Listener Added");
            });
            restartBtn.onClick.AddListener(() => SceneController.Instance.ChangeScene("Gameplay"));
        }
    }
}
