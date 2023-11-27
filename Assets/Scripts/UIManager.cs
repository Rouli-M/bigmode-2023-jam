using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    [System.Serializable]
    struct StepUI
    {
        public GameObject gameObjectUI;
        public UnityEvent eventsUI;

    }

    [SerializeField]
    private List<StepUI> _stepUIs = new List<StepUI>();

    private int _currentStep = 0;

    public void NextStep()
    {
        _stepUIs[_currentStep].gameObjectUI.SetActive(false);
        _currentStep++;
        _stepUIs[_currentStep].gameObjectUI.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
