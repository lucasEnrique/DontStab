using UnityEngine;
using System.Collections;

public class CallShadow : MonoBehaviour {

    public GameObject[] sombra;
    private int num;
    private int ant;
    private float delay;
    
    public int knivesCount;
    [SerializeField]
    private float StartAttackWait;
    public float startWait;
    public float waveWait;

    [SerializeField]
    private int knivesCoutWave;
    void Start()
    {
        StartCoroutine(SpawnWaves());
        ant = -1;
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        //delay = attackWait;
        StartAttackWait = 2.0f;
       StartCoroutine("waveGenarator", StartAttackWait);
        

    }

    void orderAtack(int shadowselect, float delay)
    {
        sombra[shadowselect].SetActive(true);
        sombra[shadowselect].ShakeScale(new Vector3(0.3f, 0.3f, 0.3f), delay, 0f);
        sombra[shadowselect].GetComponent<CallKnife>().PrepararAtaque(delay);
    }

    IEnumerator waveGenarator(float timeOfAttack)
    {
        delay = timeOfAttack;
        for (int i = 0; i < knivesCoutWave; i++)
        {
            while (num == ant)
            {
                num = (int)Random.Range(0.0f, 4.0f);
            }
            orderAtack(num, delay);

            ant = num;
            yield return new WaitForSeconds(timeOfAttack);
        }
         
        yield return new WaitForSeconds(waveWait);
        timeOfAttack = (float) 0.9 * timeOfAttack;
       
        StartCoroutine("waveGenarator", timeOfAttack);
    }
}   
