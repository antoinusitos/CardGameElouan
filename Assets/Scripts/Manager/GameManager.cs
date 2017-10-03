using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameState
{
    void OnStateEnter();
    StateCondition OnStateUpdate();
    void OnStateExit();
    EGameState GetGameState();
}

public class GameManager : MonoBehaviour 
{
    private GameState _currentGameState = new IMenuState();

    private List<StateTransition> _allTransitions = new List<StateTransition>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CreateAllTransitions();
        _currentGameState.OnStateEnter();
    }

    private void Update()
    {
        StateCondition st = _currentGameState.OnStateUpdate();
        CheckTransition(st);
    }

    private void CheckTransition(StateCondition st)
    {
        for(int i = 0; i < _allTransitions.Count; i++)
        {
            if(
                _allTransitions[i].stateIN == _currentGameState.GetGameState() &&
                _allTransitions[i].condition == st
            )
            {
                _currentGameState.OnStateExit();
                if (_allTransitions[i].afterTransition != null)
                    _allTransitions[i].afterTransition();

                _currentGameState = _allTransitions[i].stateOUT;
                _currentGameState.OnStateEnter();
                return;
            }
        }
    }

    private void CreateAllTransitions()
    {
        _allTransitions.Add(AddTransition(EGameState.MENU, StateCondition.SUCCESS, new IGameState(), null));
        _allTransitions.Add(AddTransition(EGameState.GAME, StateCondition.SUCCESS, new IScoreState(), null));
        _allTransitions.Add(AddTransition(EGameState.SCORE, StateCondition.SUCCESS, new IMenuState(), null));
    }

    private StateTransition AddTransition(EGameState stateIN, StateCondition condition, GameState stateOUT, AfterTransition afterTransition)
    {
        StateTransition st = new StateTransition();
        st.stateIN = stateIN;
        st.condition = condition;
        st.stateOUT = stateOUT;
        st.afterTransition = afterTransition;
        return st;
    }

    private static GameManager Instance = null;
    public static GameManager GetInstance() { return Instance; }
}
