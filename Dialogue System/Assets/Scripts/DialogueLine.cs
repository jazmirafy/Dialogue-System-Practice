using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "DialogueLine", menuName = "Scriptable Objects/DialogueLine")]
[System.Serializable]
public class DialogueLine : ScriptableObject
{
    public string dialogue;
    public CharacterID character;
    public AudioClip dialogueAudio;
    public List<DialogueLine> responses;
}
