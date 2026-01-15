using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstAidGame.Core
{
    public class GameManager : Singleton<GameManager>
    {
        public enum GameState { Menu, Playing, Decision, Result}
        public GameState State { get; private set; }
        public void ChangeState(GameState newState)
        {
            State = newState;
            Debug.Log($"Oyun durumu deðiþti : {newState}");
        }
    }
}