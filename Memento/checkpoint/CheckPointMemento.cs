using System;

namespace Memento.CheckPoint{
    public class CheckPointMemento
    {
        public int CheckPointLevel { get; set; }
        public int CheckPointScore { get; set; }
        public DateTime CheckPointTime { get; set; }

        public CheckPointMemento(int checkPointLevel, int checkPointScore, DateTime checkPointTime)
        {
            CheckPointLevel = checkPointLevel;
            CheckPointScore = checkPointScore;
            CheckPointTime = checkPointTime;
        }
    }    

    public class CheckPointCareTaker
    {
        public CheckPointMemento checkPoint { get; set; }
    }
}
