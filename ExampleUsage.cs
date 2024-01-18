using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    public Quest myQuest;
    
    void Start()
    {
        QuestManager.instance.AddQuest(myQuest);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            myQuest.Complete();
        }
    }
}
