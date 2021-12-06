using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minigame1 : MonoBehaviour
{
    [SerializeField] private Image Panel;
    [SerializeField] private GameObject start;
    [SerializeField] private Text matterText;
    [SerializeField] private string[] matterList;
    [SerializeField] private string[] answerList;

    private float time = 0f;
    private float F_time = 1f;
    private string answer;

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
        RefreshMatter();
    }

    private void RefreshMatter()
    {
        int count = matterList.Length;
        int num = Random.Range(0, count);

        matterText.text = matterList[num];
        answer = answerList[num];
    }
}
