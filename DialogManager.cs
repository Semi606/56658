using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public GameObject dialogPanel;

    private Queue<string> dialogQueue = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {
        EnqueueDialog("Привіт! Я персонаж гри.");
        EnqueueDialog("Це діалогове вікно.");
        EnqueueDialog("Спобуй взаємодіяти зі мною");
    }

    // Update is called once per frame
    public void EnqueueDialog(string dialog)
    {
        dialogQueue.Enqueue(dialog);
    }

    public void DisplayNextMessage()
    {
        if(dialogQueue.Count > 0){
            string currentDialog = dialogQueue.Dequeue();
            dialogText.text = currentDialog;
        } else {
            dialogPanel.SetActive(false);
            Debug.Log("діалог завершено");
        }
    }
}
