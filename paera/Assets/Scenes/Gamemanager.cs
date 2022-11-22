using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public GameObject[] Text;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(index >= 5)
           index = 5;
        if(index < 0)
           index = 0;

        if(index == 0)
        {
            Text[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;
        for(int i = 0 ; i < Text.Length; i++)
        {
            Text[i].gameObject.SetActive(false);
            Text[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
    public void Previous()
    {
        index -= 1;
        for(int i = 0 ; i < Text.Length; i++)
        {
            Text[i].gameObject.SetActive(false);
            Text[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
