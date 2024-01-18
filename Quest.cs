using UnityEngine;

public class Quest : MonoBehaviour
{
    public string questName;
    public string questDescription;
    public bool isCompleted = false;

    public void Complete()
    {
        if(!isCompleted){
            isCompleted = true;
            QuestManager.instance.CompleteQuest(this);
        }
    }
}
