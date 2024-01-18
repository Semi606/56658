using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    public static QuestManager instance;
    private List<Quest> activeQuests  = new List<Quest>();

    private void Awake(){
        if (instance == null){
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }
    
    public void AddQuest(Quest quest){
        if(!activeQuests.Contains(quest)){
            activeQuests.Add(quest);
            Debug.Log("Було додано новий квест:" + quest.questName);
        }
    }
    
    public void CompleteQuest(Quest quest){
        if(activeQuests.Contains(quest)){
        activeQuests.Remove(quest);
        Debug.Log("Було пройдено квест:" + quest.questName);
        }

    }
}
