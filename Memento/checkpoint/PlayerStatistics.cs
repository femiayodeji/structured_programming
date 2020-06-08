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
    }
}
        }
