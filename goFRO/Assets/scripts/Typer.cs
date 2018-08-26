using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Text))]

public class Typer : MonoBehaviour {

    public string[] msgs = { "Dark clothing attracts mosquitoes. Remember, they are drawn to heat and darker clothes retain more heat than light-colored clothing.", "Mosquitoes are the world’s deadliest animals", "When someone mentions the term ‘world’s deadliest animal’� you probably start thinking of sharks, tigers, crocodiles and other fierce creatures.", "Well, it may shock you to learn that it’s actually mosquitoes. Why? Well, it’s down to the harmful diseases that they are known to spread.", "Mosquitoes are as old as the Dinosaurs, with evidence of these biting insects dating back to the Triassic Period!" };
    private Text textComp;
    public float startDelay = 2f;
    public float typeDelay = 0.01f;
    public AudioClip typeSound;

    string msg;

    // Use this for initialization
    void Start() {
        msg = msgs[Random.Range(0, 4)];
        StartCoroutine("TypeIn");
    }

    public void Randomize()
    {
        msg = msgs[Random.Range(0, 4)];
        StartCoroutine("TypeIn");
    }

	void Awake()
	{
		textComp = GetComponent<Text>();
	}

	public IEnumerator TypeIn()
	{
		yield return new WaitForSeconds(startDelay);

		for(int i = 0; i < msg.Length; i++)
		{
			textComp.text = msg.Substring(0,i);
			GetComponent<AudioSource>().PlayOneShot(typeSound);
			yield return new WaitForSeconds(typeDelay);
		}
	}
	
	public IEnumerator Typeoff()
	{
		yield return new WaitForSeconds(startDelay);

		for(int i = msg.Length; i >= 0; i--)
		{
			textComp.text = msg.Substring(0,i);
			yield return new WaitForSeconds(typeDelay);
		}
	}
}
