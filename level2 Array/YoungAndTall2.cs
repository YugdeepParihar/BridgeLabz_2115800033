using System;

class FriendsComparison {
    static void Main() {
        string[] friendNames = { "Amar", "Akbar", "Anthony" };
        int[] friendAges = new int[3];
        double[] friendHeights = new double[3];

        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"Enter age and height for {friendNames[i]}:");
            friendAges[i] = Convert.ToInt32(Console.ReadLine());
            friendHeights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestIndex = 0, tallestIndex = 0;
        for (int i = 1; i < 3; i++) {
            if (friendAges[i] < friendAges[youngestIndex]) youngestIndex = i;
            if (friendHeights[i] > friendHeights[tallestIndex]) tallestIndex = i;
        }

        Console.WriteLine($"Youngest Friend: {friendNames[youngestIndex]}");
        Console.WriteLine($"Tallest Friend: {friendNames[tallestIndex]}");
    }
}
