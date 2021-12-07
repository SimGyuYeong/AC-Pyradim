using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minigame1 : MonoBehaviour
{
    [SerializeField] private Image Panel;
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject FailedCanvas;
    [SerializeField] private GameObject CompeleteCanvas;
    [SerializeField] private Text matterText;
    [SerializeField] private string[] matterList;
    [SerializeField] private string[] answerList;
    [SerializeField] private InputField answerInput;
    [SerializeField] private Button Up7Button;

    private float time = 0f;
    private float F_time = 1f;
    private string answer;

    private int count = 0;
    private int failedCount = 0;

    public void AnswerCheck()
    {
        if (answerInput.text == answer)
        {
            count++;
            if (count == 3) CompeleteCanvas.SetActive(true);
            else RefreshMatter();
        }
        else
        {
            FailedCanvas.SetActive(true);
            count = 0;
            failedCount++;
            if (failedCount >= 7) Up7Button.gameObject.SetActive(true);
        }
    }

    public void Fade()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        Color alpha = Panel.color;
        while(alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        start.SetActive(false);
        time = 0f;

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panel.color = alpha;
            yield return null;
        }
        Panel.gameObject.SetActive(false);
        
    }

    public void RefreshMatter()
    {
        int count = matterList.Length;
        int num = Random.Range(0, count);

        matterText.text = matterList[num];
        answer = answerList[num];

        answerInput.text = "";
    }

    public void Retry()
    {
        RefreshMatter();
        FailedCanvas.SetActive(false);
    }
}
