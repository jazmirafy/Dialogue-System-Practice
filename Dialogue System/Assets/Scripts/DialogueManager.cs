using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : Singleton<DialogueManager>
{
    public DialogueDatabase database;
    DialogueLine m_currentLine = null;

    Dictionary<string, DialogueLine> m_DialogueTable = new Dictionary<string, DialogueLine>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(DialogueLine line in database.database)
        {
            m_DialogueTable.Add(line.name, line);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartDialogue(string dialoguename)
    {
        if(m_DialogueTable.TryGetValue(dialoguename, out m_currentLine))
        {
            
        }
    }
    public void SelectResponse(int index)
    {
        
    }
}
