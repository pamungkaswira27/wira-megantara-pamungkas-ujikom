using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField]
    private AudioClip _throwSFX;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayThrowSFX()
    {
        PlaySFX(_throwSFX);
    }

    private void PlaySFX(AudioClip clip)
    {
        Vector3 camPosition = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(clip, camPosition);
    }
}
