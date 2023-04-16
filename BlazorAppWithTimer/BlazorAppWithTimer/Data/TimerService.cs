namespace BlazorAppWithTimer.Data
{
    public class TimerService
    {
        public string displayText = "time out";
        public bool isEnded = false;
        public bool firstRender = true;
        public TimeSpan timeLeft = new TimeSpan(0, 0, 15);

        public void AddMinute()
        {
            timeLeft = timeLeft.Add(new TimeSpan(0, 1, 0));
        }
    }
}