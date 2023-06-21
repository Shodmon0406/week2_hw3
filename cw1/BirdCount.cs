class BirdCount
{
    List<int> _birds = new List<int>();
    int cnt = 0;
    int cnt1 = 0;
    int sum = 0;
    public BirdCount(List<int> birds)
    {
        _birds = birds;
    }
    public void LastWeek()
    {
        int cnt = 0;
        System.Console.Write("[");
        foreach (var bird in _birds)
        {
            cnt++;
            System.Console.Write(bird);
            if (cnt < _birds.Count)
            {
                System.Console.Write(", ");
            }
        }
        System.Console.WriteLine("]");
    }
    public int Today()
    {
        return _birds[_birds.Count - 1];
    }
    public void IncrementTodaysCount()
    {
        _birds[_birds.Count - 1] ++;
    }
    public bool HasDayWithoutBirds()
    {
        foreach (var bird in _birds)
        {
            if (bird == 0)
            {
                cnt++;
            }
        }
        if (cnt != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int CountForFirstDays(int day)
    {
        for (int i = 0; i < day; i++)
        {
            sum += _birds[i];
        }
        return sum;
    }
    public int BusyDays()
    {
        foreach (var bird in _birds)
        {
            if (bird >= 5)
            {
                cnt1++;
            }
        }
        return cnt1;
    }
}