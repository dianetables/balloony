using System;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Serialization;

namespace TMG.BloonsTD.Gameplay
{
    public class GameController : MonoBehaviour
    {
        public static GameController Instance;
        private void InitializeStatistics()
        {
            //_curGameStatistics.SetGameStatistics(_startingGameStatistics);
            //_roundController.Initialize(_curGameStatistics);
        }

        private void InitializeUI()
        {
            // OnRoundChanged?.Invoke(_curGameStatistics.Rounds);
            // OnMoneyChanged?.Invoke(_curGameStatistics.Money);
            // OnLivesChanged?.Invoke(_curGameStatistics.Lives);
        }
        
        public void BeginNewRound()
        {
            UpdateRoundText();
            // _roundController.StartNextRound();
        }

        private void UpdateRoundText()
        {
            // OnRoundChanged?.Invoke(_curGameStatistics.Rounds);
        }
    }
}