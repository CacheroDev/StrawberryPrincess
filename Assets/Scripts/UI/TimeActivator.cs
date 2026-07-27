

using UnityEngine;

public class TimeActivator : MonoBehaviour
{
 
    public void TimeFreeze()
    {
        Time.timeScale = 0;
    }

    public void TimeDefreeze()
    {
        Time.timeScale = 1;
    }
}
