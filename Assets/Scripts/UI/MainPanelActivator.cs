


using UnityEngine;

public class MainPanelActivator : MonoBehaviour
{
    [SerializeField] GameObject panel;

    
    public void ActivatePanel()
    {
        panel.SetActive(true);
    }

    public void DeactivatePanel()
    {
        panel.SetActive(false);
    }
}
