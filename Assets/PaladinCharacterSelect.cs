using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinCharacterSelect : MonoBehaviour
{
    public Animator paladin_am;
    // Start is called before the first frame update
    void Start()
    {
        paladin_am = GetComponent<Animator>();
        Debug.Log(paladin_am.ToString());
        //call coroutine
        StartCoroutine(SpinAndDieRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpinAndDieRoutine() 
    {
        paladin_am.SetTrigger("spin");

        yield return new WaitForSeconds(4f);

        paladin_am.SetTrigger("die");
    }
}


