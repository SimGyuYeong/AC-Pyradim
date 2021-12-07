using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameOther : MonoBehaviour
{
    [SerializeField] private GameObject FailedCanvas;
    [SerializeField] private GameObject CompeleteCanvas;
    [SerializeField] private Text matterText;
    [SerializeField] private GameObject[] startCanvas;
    [SerializeField] private Text[] answerText;
    [SerializeField] private string[] matterList;
    [SerializeField] private int[] answerList;
    [SerializeField] private string[] choiseList;
    

    private int answer;

    private int count = 0;

    public void AnswerCheck(int selectNum)
    {
        if (selectNum == answer)
        {
            count++;
            if (count >= 3)
            {
                CompeleteCanvas.SetActive(true);

            }
            else
            {
                RefreshMatter();
            }

        }
        else
        {
            FailedCanvas.SetActive(true);
            count = 0;
        }
    }

    public void RefreshMatter()
    {
        int count = matterList.Length;
        int num = Random.Range(0, count);

        matterText.text = matterList[num];
        answer = answerList[num];

        int add = 0;

        for(int i = 0; i < 4; i++)
        {
            add = num * 4;
            answerText[i].text = choiseList[add+i];
        }
    }

    public void closeStartCanvas(int num)
    {
        startCanvas[num].SetActive(false);
    }

    public void Retry()
    {
        RefreshMatter();
        FailedCanvas.SetActive(false);
    }
}
