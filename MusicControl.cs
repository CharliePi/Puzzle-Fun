using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicControl : MonoBehaviour {

    public AudioMixerSnapshot outOfCombat;
    public AudioMixerSnapshot inCombat;

    public AudioClip[] stings;
    public AudioSource stringSource;
    public float bpm = 120;

    private float m_TransitionIn;
    private float m_TransitionOut;
    private float m_QuarterNote;

    // Use this for initialization
    void Start ()
    {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote * 32;
	}
	
    void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("CombatZone"))
        {
            inCombat.TransitionTo(m_TransitionIn);
        }
    }
    void OnTriggerExit(Collider2D other)
    {
        if (other.CompareTag("CombatZone"))
        {
            outOfCombat.TransitionTo(m_TransitionOut);
        }
    }
}
