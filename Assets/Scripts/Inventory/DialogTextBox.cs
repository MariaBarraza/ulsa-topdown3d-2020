using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTextBox : MonoBehaviour
{
    [SerializeField]
    Text dialog;

    [SerializeField]
    string message;

    IEnumerator animateText;

    [SerializeField, Range(0.01f, 4f)]
    float animationsSpeed;

    /*public string TextDialog
    {
        set => dialog.text = value;
    }*/

    public void ClearText()
    {
        dialog.text = "";
    }
    public void ShowDialog()
    {
        animateText = Animate(animationsSpeed);
        StartCoroutine(animateText);
    }
   

    public string Message { get => message; set => message = value; }

    IEnumerator Animate(float time)
    {
     int i = 0;
        while(i < Message.Length)
        {
            dialog.text += message[i];
            i++;
            yield return new WaitForSeconds(time); 
        }
    }
}
