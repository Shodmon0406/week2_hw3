var birds = new List<int>{0, 2, 5, 3, 7, 8, 4};

var birdCount = new BirdCount(birds);
birdCount.LastWeek();
System.Console.WriteLine(birdCount.Today());
birdCount.IncrementTodaysCount();
birdCount.IncrementTodaysCount();
System.Console.WriteLine(birdCount.Today());
System.Console.WriteLine(birdCount.HasDayWithoutBirds());
System.Console.WriteLine(birdCount.CountForFirstDays(4));
System.Console.WriteLine(birdCount.BusyDays());