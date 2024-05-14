//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

// int[] numbers = { 1, 1, 2, 3, 5, 8 };
// foreach (int number in numbers) 
// {
//     if (number % 2 > 0) Console.WriteLine(number);
// }

string greenEggsPassage = "I would not, could not, in a box. I would not, could not with a fox.  I will not eat them in a house. I will not eat them with a mouse.";

string[] greenEggsWords = greenEggsPassage.Split(' ');
Console.WriteLine(string.Join(",", greenEggsWords));

string[] greenEggsSentences = greenEggsPassage.Split(". ");
Console.WriteLine(string.Join(" | ", greenEggsSentences));