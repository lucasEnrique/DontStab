using UnityEngine;
using System.Collections;

public class CallShadow : MonoBehaviour {

    public GameObject[] sombra;
    private int num;
    private int ant;
    private float delay;
    
    public int knivesCount;
    public float attackWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
        ant = -1;
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        delay = attackWait;
        while (true)
        {
            for (int i = 0; i < knivesCount; i++)
            {
                while(num == ant)
                {
                    num = (int)Random.Range(0.0f, 4.0f);
                }

                orderAtack(num, delay);

                ant = num;
                yield return new WaitForSeconds(attackWait);
            }
            yield return new WaitForSeconds(waveWait);

            knivesCount = knivesCount + 5;
            if(delay-1 < 0.5f)
                delay = delay - 0.2f;
        }
    }

    void orderAtack(int shadowselect, float delay)
    {
        sombra[shadowselect].SetActive(true);
        sombra[shadowselect].ShakeScale(new Vector3(0.3f, 0.3f, 0.3f), delay, 0f);
        sombra[shadowselect].GetComponent<CallKnife>().PrepararAtaque(delay);
    }
}
