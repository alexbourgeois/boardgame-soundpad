using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SoundButton", menuName = "SoundButton")]
public class SoundButtonData : ScriptableObject
{
    public Sprite artwork;
    public AudioClip sound;
}
