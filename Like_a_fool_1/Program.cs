/*
A dice game played with five six-sided dice.
Three 1's => 1000 points  
Three 6's =>  600 points 
Three 5's =>  500 points 
Three 4's =>  400 points 
Three 3's =>  300 points 
Three 2's =>  200 points 
One   1   =>  100 points 
One   5   =>   50 point 
*/


Console.WriteLine(Score(new int[] { 2, 3, 4, 6, 2 })); // 0
Console.WriteLine(Score(new int[] { 4, 4, 4, 3, 3 })); // 400
Console.WriteLine(Score(new int[] { 2, 4, 4, 5, 4 })); // 450
Console.WriteLine(Score(new int[] { 1, 5, 5, 5, 5 })); //650
Console.WriteLine(Score(new int[] { 3, 3, 3, 3, 3 })); //300


static int Score(int[] dice)
{
    int total = 0;
    var numGroup = dice.GroupBy(n => n);

    foreach (var num in numGroup)
    {
        if (num.Count() == 3)
        {
            if (num.Key != 1)
            {
                total += num.Key * 100;
            }
            else
            {
                total += num.Key * 1000;
            }
        }

        else if (num.Count() <= 2)
        {
            if (num.Key == 1)
            {
                total += num.Count() * 100;
            }
            else if (num.Key == 5)
            {
                total += num.Count() * 50;
            }
        }
        else if (num.Count() > 3)
        {
            if (num.Key == 1)
            {
                if (num.Count() == 4)
                {
                    total += 1100;
                }
                else
                {
                    total += 1200;
                }
            }
            else if (num.Key == 5)
            {
                if (num.Count() == 4)
                {
                    total += 550;
                }
                else
                {
                    total += 600;
                }
            }
            else
            {
                total += num.Key * 100;
            }
        }
    }

    return total;
}