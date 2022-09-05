//bool isCorrect = 11 + 1 != 2;
//Console.WriteLine(isCorrect);

// isCorrect blir true, eftersom programmet frågar om 11 + 1, dvs 12, inte är samma sak som 2. 



//bool isCorrect = 11 + 1 == 2;
//Console.WriteLine(isCorrect);

// Nu blir isCorrect false, eftersom jag frågar om 11 + 1, dvs 12 är samma sak som 2, vilket det inte är.



//bool isCorrect = 11 + 1 is not 2;
//Console.WriteLine(isCorrect);

// Is not är samma sak för kompilatorn som !=, därför blir isCorrect true. Eftersom 12 inte är 2.


//bool isCorrect = 12 != 2;
//Console.WriteLine(isCorrect);



bool isCorrect = 1 + 1 is 2;
Console.WriteLine(isCorrect);

//Eftersom 1 + 1 är 2, och 2 = 2, så blir isCorrect True.
