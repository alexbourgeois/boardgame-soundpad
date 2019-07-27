using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class SoundButtonDisplay : MonoBehaviour
{
    public Image artwork;
    public AudioSource audio;

    public SoundButtonData data;

    // Start is called before the first frame update
    void Start()
    {
        artwork.sprite = data.artwork;
        audio.clip = data.sound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
