using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    // Start is called before the first frame update
    public string name;

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;

    public bool loop;
    [Range(0f, 1f)]
    public float pitch;
    [HideInInspector]
    public AudioSource source;
}
