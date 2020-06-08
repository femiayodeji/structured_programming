using System;
using Memento.checkPoint;

namespace Memento.checkpoint
{
    public class PlayerStatistics
    {
        public int LevelId { get; set; }
        public int Score { get; set; }
        public DateTime CheckPointTime { get; set; }

        //store snapshot
        public CheckPointMemento CreateCheckPoint(PlayerStatistics playerStatistics)
        {
            return new CheckPointMemento(playerStatistics.LevelId, playerStatistics.Score, playerStatistics.CheckPointTime);
        }        

        public void RestoreCheckPoint(CheckPointMemento checkPointMemento)
        {
            LevelId = checkPointMemento.CheckPointLevel;
            Score = checkPointMemento.CheckPointScore;
            CheckPointTime = checkPointMemento.CheckPointTime;
        }

        public void PrintStatistics()
        {
            Console.WriteLine("Checkpoint time : {0}", CheckPointTime);
            Console.WriteLine("Level : {0}", LevelId);
            Console.WriteLine("Score : {0}", Score);
        }
    }
}
