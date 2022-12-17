using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameTimer;
    [SerializeField] private GameObject _pachinkoBallPrefab;
    [SerializeField] private Transform _pachinkoBallDropOff;
    [SerializeField] private GameObject _pachinkoTubeBottom;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_pachinkoBallPrefab, _pachinkoBallDropOff.position, Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            _pachinkoTubeBottom.SetActive(false);
            StartCoroutine(ResetTubeBottom());

        }
        
    }
    private void FixedUpdate()
    {
        gameTimer = Time.time;

    }

    IEnumerator ResetTubeBottom()
    {
        yield return new WaitForSeconds(1);
        _pachinkoTubeBottom.SetActive(true);
    }
}
