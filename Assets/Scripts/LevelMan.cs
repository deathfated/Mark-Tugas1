using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMan : MonoBehaviour
{
    public delegate void GameOver();
    public static event GameOver OnGameOver;
    
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
    //private int _enemyCounter;
    //private float _runningSpawnDelay;

    //private float _timer;

    [SerializeField] private bool SpawnComplete;
    [SerializeField] private bool Spawn1Complete;
    [SerializeField] private bool Spawn2Complete;
    [SerializeField] private bool Spawn3Complete;
    [SerializeField] private bool Spawn4Complete;
    [SerializeField] private bool Spawn5Complete;
    [SerializeField] private bool Spawn6Complete;
    [SerializeField] private bool Spawn7Complete;
    [SerializeField] private bool Spawn8Complete;
    [SerializeField] private bool SpawnVComplete;
    [SerializeField] private bool SpawnV1Complete;
    [SerializeField] private bool SpawnV2Complete;

    [SerializeField] private GameObject E;
    [SerializeField] private GameObject E1;
    [SerializeField] private GameObject E2;
    [SerializeField] private GameObject E3;
    [SerializeField] private GameObject E4;
    [SerializeField] private GameObject E5;
    [SerializeField] private GameObject E6;
    [SerializeField] private GameObject E7;
    [SerializeField] private GameObject E8;
    [SerializeField] private GameObject V;
    [SerializeField] private GameObject V1;
    [SerializeField] private GameObject V2;

    [SerializeField] private int ESpawn;
    [SerializeField] private int E1Spawn;
    [SerializeField] private int E2Spawn;
    [SerializeField] private int E3Spawn;
    [SerializeField] private int E4Spawn;
    [SerializeField] private int E5Spawn;
    [SerializeField] private int E6Spawn;
    [SerializeField] private int E7Spawn;
    [SerializeField] private int E8Spawn;
    [SerializeField] private int VSpawn;
    [SerializeField] private int V1Spawn;
    [SerializeField] private int V2Spawn;


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

    private void SetCurrentLives(int currentLives)
    {
        _currentLives = Mathf.Max(currentLives, 0);
        _lives.text = $"{_currentLives}";

        HealthMan script = GameObject.FindObjectOfType<HealthMan>();
        script.ChangeHealth(_currentLives);
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




        /*_timer += Time.deltaTime;

        if (_timer >= ESpawn && SpawnComplete == false)
        {
            if (E.activeSelf == true)
            {
                return;
            }
            E.SetActive(!E.activeInHierarchy);
            SpawnComplete = true;
        }
        if (_timer >= E1Spawn && Spawn1Complete == false)
        {
            if (E1.activeSelf == true)
            {
                return;
            }
            E1.SetActive(!E1.activeInHierarchy);
            Spawn1Complete = true;
        }
        if (_timer >= E2Spawn && Spawn2Complete == false)
        {
            if (E2.activeSelf == true)
            {
                return;
            }
            E2.SetActive(!E2.activeInHierarchy);
            Spawn2Complete = true;
        }
        if (_timer >= E3Spawn && Spawn3Complete == false)
        {
            if (E3.activeSelf == true)
            {
                return;
            }
            E3.SetActive(!E3.activeInHierarchy);
            Spawn3Complete = true;
        }
        if (_timer >= E4Spawn && Spawn4Complete == false)
        {
            if (E4.activeSelf == true)
            {
                return;
            }
            E4.SetActive(!E4.activeInHierarchy);
            Spawn4Complete = true;
        }
        if (_timer >= E5Spawn && Spawn5Complete == false)
        {
            if (E5.activeSelf == true)
            {
                return;
            }
            E5.SetActive(!E5.activeInHierarchy);
            Spawn5Complete = true;
        }
        if (_timer >= E6Spawn && Spawn6Complete == false)
        {
            if (E6.activeSelf == true)
            {
                return;
            }
            E6.SetActive(!E6.activeInHierarchy);
            Spawn6Complete = true;
        }
        if (_timer >= E7Spawn && Spawn7Complete == false)
        {
            if (E7.activeSelf == true)
            {
                return;
            }
            E7.SetActive(!E7.activeInHierarchy);
            Spawn7Complete = true;
        }
        if (_timer >= E8Spawn && Spawn8Complete == false)
        {
            if (E8.activeSelf == true)
            {
                return;
            }
            E8.SetActive(!E8.activeInHierarchy);
            Spawn8Complete = true;
        }
        if (_timer >= VSpawn && SpawnVComplete == false)
        {
            if (V.activeSelf == true)
            {
                return;
            }
            V.SetActive(!V.activeInHierarchy);
            SpawnVComplete = true;
        }
        if (_timer >= V1Spawn && SpawnV1Complete == false)
        {
            if (V1.activeSelf == true)
            {
                return;
            }
            V1.SetActive(!V1.activeInHierarchy);
            SpawnV1Complete = true;
        }
        if (_timer >= V2Spawn && SpawnV2Complete == false)
        {
            if (V2.activeSelf == true)
            {
                return;
            }
            V2.SetActive(!V2.activeInHierarchy);
            SpawnV2Complete = true;
        }
        */
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
        }

        //this func can remove later:
    public void SetTotalEnemy(int totalEnemy)
    {
        _enemyCounter = totalEnemy;
    }*/

    public void ReduceLives(int value)
    {
        SetCurrentLives(_currentLives - value);

        if (_currentLives <= 0)
        {
            SetGameOver();
        }
    }

    private void SetGameOver()
    {
        IsOver = true;
        OnGameOver();

         _goPanel.SetActive(true);
    }
}

  