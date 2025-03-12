using UnityEngine;
using UnityEngine.UI;

namespace COMP397
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Button playBtn;
        [SerializeField] private Button loadBtn;
        [SerializeField] private Button optionsBtn;
        [SerializeField] private Button quitBtn;

        private void Start()
        {
            playBtn.onClick.AddListener(() => {
                SceneController.Instance.ChangeScene("Gameplay");
                Debug.Log("Listener Added");
            });
        }
    }
}
