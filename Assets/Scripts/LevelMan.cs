using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMan : MonoBehaviour
{
    [SerializeField] private int _maxLives = 3;
    //[SerializeField] private int _totalEnemy = 15;
    //[SerializeField] private float _spawnDelay = 5f;

    [SerializeField] GameObject _spawnArea;
    [SerializeField] GameObject _goPanel;
    [SerializeField] private Text _statusInfo;
    [SerializeField] private Text _lives;

    //[SerializeField] private EnemyContoller[] _enemyPrefabs;

    //private List<EnemyContoller> _spawnedEnemies = new List<EnemyContoller>();

    private int _currentLives;
    private int _enemyCounter;
    private float _runningSpawnDelay;
    private float _timer;

    public bool SpawnComplete;
    public bool Spawn1Complete;
    public bool Spawn2Complete;
    public bool Spawn3Complete;
    public bool Spawn4Complete;
    public bool Spawn5Complete;
    public bool Spawn6Complete;
    public bool Spawn7Complete;
    public bool Spawn8Complete;
    public bool SpawnVComplete;
    public bool SpawnV1Complete;
    public bool SpawnV2Complete;

    public GameObject E;
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public GameObject E5;
    public GameObject E6;
    public GameObject E7;
    public GameObject E8;
    public GameObject V;
    public GameObject V1;
    public GameObject V2;

    public int ESpawn;
    public int E1Spawn;
    public int E2Spawn;
    public int E3Spawn;
    public int E4Spawn;
    public int E5Spawn;
    public int E6Spawn;
    public int E7Spawn;
    public int E8Spawn;
    public int VSpawn;
    public int V1Spawn;
    public int V2Spawn;


    public bool IsOver { get; private set; }

    private static LevelMan _instance = null;
    public static LevelMan Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<LevelMan>();
            }

            return _instance;
        }
    }

    private void Start()
    {
        SetCurrentLives(_maxLives);
    }

    public void SetCurrentLives(int currentLives)
    {
        _currentLives = Mathf.Max(currentLives, 0);
        _lives.text = $"{_currentLives}";
    }

    private void Update()
    {
        /*_runningSpawnDelay -= Time.unscaledDeltaTime;

        if (_runningSpawnDelay <= 0f)
        {
            //SpawnEnemy();
            _runningSpawnDelay = _spawnDelay;
        }

        foreach (EnemyContoller enemy in _spawnedEnemies)
        {
            if (!enemy.gameObject.activeSelf)
            {
                continue;
            }
        }*/

        _timer += Time.deltaTime;

        if (_timer >= ESpawn && Spawn1Complete == false)
        {
            if (E.activeSelf == true)
            {
                return;
            }
            E.SetActive(!E.activeInHierarchy);
            SpawnComplete = true;
        }
        if (_timer >= E1Spawn && Spawn2Complete == false)
        {
            if (E1.activeSelf == true)
            {
                return;
            }
            E1.SetActive(!E1.activeInHierarchy);
            Spawn1Complete = true;
        }
        if (_timer >= E2Spawn && Spawn3Complete == false)
        {
            if (E2.activeSelf == true)
            {
                return;
            }
            E2.SetActive(!E2.activeInHierarchy);
            Spawn2Complete = true;
        }
        if (_timer >= E3Spawn && Spawn4Complete == false)
        {
            if (E3.activeSelf == true)
            {
                return;
            }
            E3.SetActive(!E3.activeInHierarchy);
            Spawn3Complete = true;
        }
        if (_timer >= E4Spawn && Spawn5Complete == false)
        {
            if (E4.activeSelf == true)
            {
                return;
            }
            E4.SetActive(!E4.activeInHierarchy);
            Spawn4Complete = true;
        }
        if (_timer >= E5Spawn && Spawn3Complete == false)
        {
            if (E5.activeSelf == true)
            {
                return;
            }
            E5.SetActive(!E5.activeInHierarchy);
            Spawn5Complete = true;
        }
        if (_timer >= E6Spawn && Spawn4Complete == false)
        {
            if (E6.activeSelf == true)
            {
                return;
            }
            E6.SetActive(!E6.activeInHierarchy);
            Spawn6Complete = true;
        }
        if (_timer >= E7Spawn && Spawn5Complete == false)
        {
            if (E7.activeSelf == true)
            {
                return;
            }
            E7.SetActive(!E7.activeInHierarchy);
            Spawn7Complete = true;
        }
        if (_timer >= E8Spawn && Spawn5Complete == false)
        {
            if (E8.activeSelf == true)
            {
                return;
            }
            E8.SetActive(!E8.activeInHierarchy);
            Spawn8Complete = true;
        }
        if (_timer >= VSpawn && Spawn5Complete == false)
        {
            if (V.activeSelf == true)
            {
                return;
            }
            V.SetActive(!V.activeInHierarchy);
            Spawn5Complete = true;
        }
        if (_timer >= V1Spawn && Spawn5Complete == false)
        {
            if (V1.activeSelf == true)
            {
                return;
            }
            V1.SetActive(!V1.activeInHierarchy);
            Spawn5Complete = true;
        }
        if (_timer >= V2Spawn && Spawn5Complete == false)
        {
            if (V2.activeSelf == true)
            {
                return;
            }
            V2.SetActive(!V2.activeInHierarchy);
            Spawn5Complete = true;
        }

    }
        /*private void SpawnEnemy()
        {
            SetTotalEnemy(--_enemyCounter);

            int randomIndex = Random.Range(0, _enemyPrefabs.Length);
            string enemyIndexString = (randomIndex + 1).ToString();

            GameObject newEnemyObj = _spawnedEnemies.Find(e => !e.gameObject.activeSelf && e.name.Contains(enemyIndexString))?.gameObject;


            if (newEnemyObj == null)
            {
                newEnemyObj = Instantiate(_enemyPrefabs[randomIndex].gameObject);
            }


            EnemyContoller newEnemy = newEnemyObj.GetComponent<EnemyContoller>();
            if (!_spawnedEnemies.Contains(newEnemy))
            {
                _spawnedEnemies.Add(newEnemy);
            }

            newEnemy.transform.position = _spawnArea.transform.position;

            newEnemy.gameObject.SetActive(true);
        }*/

        //this func can remove later:
    public void SetTotalEnemy(int totalEnemy)
    {
        _enemyCounter = totalEnemy;
    }

    public void ReduceLives(int value)
    {
        SetCurrentLives(_currentLives - value);
        if (_currentLives <= 0)
        {
            SetGameOver(false);
        }
    }

    public void SetGameOver(bool isWin)
    {
        IsOver = true;

        //_statusInfo.text = isWin ? "You Win!" : "You Lose!";
         _goPanel.gameObject.SetActive(true);
    }
}

  