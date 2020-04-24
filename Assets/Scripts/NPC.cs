using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    DialogTextBox npcTextBox;

    [SerializeField,TextArea(3,5)]
    string npcDialog;
    public void StartTalking()
    {
        npcTextBox.gameObject.SetActive(true);
        npcTextBox.Message = npcDialog;
        npcTextBox.ShowDialog();
    }


    public void StopTalking()
    {
        npcTextBox.gameObject.SetActive(false);
        npcTextBox.ClearText();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartTalking();
        }
    }
       void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StopTalking();
        }
    }
}
