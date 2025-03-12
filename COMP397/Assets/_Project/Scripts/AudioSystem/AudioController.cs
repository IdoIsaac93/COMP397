using Unity.VisualScripting;
using UnityEngine;

namespace COMP397
{
    public class AudioController : MonoBehaviour
    {
        [SerializeField] private AudioAsset menuMusic;
        [SerializeField] private AudioSource menuMusicSource;
        private void Start()
        {
            menuMusicSource.clip = menuMusic.audioClip;
            menuMusicSource.volume = menuMusic.audioVolume;
            menuMusicSource.loop = menuMusic.audioLooping;
            menuMusicSource.Play();
        }
    }
}
