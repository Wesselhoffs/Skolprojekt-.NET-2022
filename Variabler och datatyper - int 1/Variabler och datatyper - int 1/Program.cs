int myAge = 65;
string myName = "Bill Gates";
Console.WriteLine("Jag är " + myAge + " år gammal.");
Console.WriteLine("Jag heter " + myName + " och är " + myAge + " år gammal.");
string formattedString = String.Format("Jag heter {0} och är {1} år gammal",myName, myAge);
Console.WriteLine(formattedString);