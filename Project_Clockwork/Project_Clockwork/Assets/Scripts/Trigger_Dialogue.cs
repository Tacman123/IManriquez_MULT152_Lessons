using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Dialogue : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actor;
}
[System.Serializable]
public class Message
{
    public int actorId;
    public string message;
}

public class Actor
{
    public string name;
    public Sprite sprite;
}
