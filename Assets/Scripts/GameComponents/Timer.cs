using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    private float m_time;
    private float totalTime;
    public Timer(float time)
    {
        m_time = 0;
        totalTime = time;

        
    }

    public bool IsTriggered()
    {
        if(m_time > totalTime)
        {
            m_time = 0;
            return true;
        }
        return false;
    }

    // Update is called once per frame
    public void Tick()
    {
        m_time += Time.deltaTime;
    }
}
