using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Texture2D _cursorArrow;

    private State _currentState;
    private bool _isSwitchingState;

    public GameObject panelMainMenu;
    public GameObject centerScreen;
    public GameObject selectInitAnim;
    public GameObject panelSelect;
    public GameObject canvas;
    public GameObject game;
    public static GameManager Instance { get; private set;}

    public enum State
    {
        MAINMENU,
        //GAMESETTINGS,
        SELECTINIT,
        SELECT,
        //SONGSETTINGS,
        SONGLOAD,
        SONGINIT,
        SONG,
        SONGRESULTS
    }
    void Start()
    {

        //INIT
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        } else {
            Destroy(gameObject);
        }
        SwitchState(State.MAINMENU);

            

    }


    void Update()
    {
        switch (_currentState)
        {
            case State.MAINMENU:
                break;
            case State.SELECTINIT:
                if (_isSwitchingState == false)
                {
                    SwitchState(State.SELECT);
                }
                break;
            case State.SELECT:
                break;
            case State.SONGLOAD:
                break;
            case State.SONGINIT:
           
                break;
            case State.SONG:
                break;
            case State.SONGRESULTS:
                break;
        }
    }

    private void BeginState(State state)
    {
        switch (_currentState)
        {
            case State.MAINMENU:
                centerScreen.SetActive(true);
                panelMainMenu.SetActive(true);
                break;
            case State.SELECTINIT:
                selectInitAnim.SetActive(true);
                break;
            case State.SELECT:
                centerScreen.SetActive(true);
                panelSelect.SetActive(true);
                break;
            case State.SONGLOAD:
                break;
            case State.SONGINIT:
                break;
            case State.SONG:
                //Change later
                game.SetActive(true);
                break;
            case State.SONGRESULTS:
                break;
        }
    }

    private void EndState()
    {
        switch (_currentState)
        {
            case State.MAINMENU:
                centerScreen.SetActive(false);
                panelMainMenu.SetActive(false);
                break;
            case State.SELECTINIT:
                selectInitAnim.SetActive(false);
                break;
            case State.SELECT:
                //CHANGE THIS LATER
                canvas.SetActive(false);
                break;
            case State.SONGLOAD:
                break;
            case State.SONGINIT:
                break;
            case State.SONG:
                break;
            case State.SONGRESULTS:
                break;
            default:
                break;
        }
    }

    public void SwitchState(State newState, float delay = 0)
    {
        StartCoroutine(SwitchDelay(newState, delay));
    }

    public IEnumerator SwitchDelay(State newState, float delay)
    {
        _isSwitchingState = true;
        EndState();
        _currentState = newState;
        BeginState(newState);
        yield return new WaitForSeconds(delay);
        _isSwitchingState = false;
    }
}