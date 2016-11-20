using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Order());
	}

    IEnumerator Order()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene(1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
