using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SpeedrunTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text bestTimeText;
    public static SpeedrunTimer instance;
    private float elapsedTime = 0f;
    private bool isRunning = false;
    private float bestTime = Mathf.Infinity; // PB começa infinito
    public GameObject boss;
    private int TS = 0;

    void Start()
    {
        // Carregar melhor tempo salvo
        if (PlayerPrefs.HasKey("BestTime"))
        {
            bestTime = PlayerPrefs.GetFloat("BestTime");
            UpdateBestTimeUI();
        }
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            if (TS == 0)
            {
                StartTimer();
                TS++;
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StopTimer();
        }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (timerText == null)
        {
            TMP_Text newText = FindObjectOfType<TMP_Text>();
            if (newText != null) timerText = newText;
        }
    }


    void UpdateTimerUI()
    {
        timerText.text = FormatTime(elapsedTime);
    }

    void UpdateBestTimeUI()
    {
        if (bestTime < Mathf.Infinity)
            bestTimeText.text = "BT: " + FormatTime(bestTime);
        else
            bestTimeText.text = "BT: --:--.---";
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        int milliseconds = Mathf.FloorToInt((time * 1000) % 1000);
        return string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, milliseconds);
    }

    public void StartTimer() => isRunning = true;
    public void StopTimer()
    {
        isRunning = false;

        // Checa se é novo recorde
        if (elapsedTime > bestTime)
        {
            bestTime = elapsedTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
            PlayerPrefs.Save();
            UpdateBestTimeUI();
        }
    }
    public void ResetTimer()
    {
        isRunning = false;
        elapsedTime = 0f;
        UpdateTimerUI();
    }
}
