using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Button nevar;
    public GameObject nieve;

    void Start()
    {
        Button btn = nevar.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnCLick);    
    }

    void TaskOnCLick()
    {
        nieve.SetActive(true);
    }
}