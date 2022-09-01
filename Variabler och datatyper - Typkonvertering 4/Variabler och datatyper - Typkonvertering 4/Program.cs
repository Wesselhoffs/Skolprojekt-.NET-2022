//float gotgatan = 1.6f;
//int hornsgatan = 2;
//int sum = hornsgatan + gotgatan;
//Console.WriteLine($"Götgatan (antal km) + Hornsgatan (antal km) = {sum}"); 

// Kompilatorn klagar över att den kan inte konvertera float till int rakt av.

//float gotgatan = 1.6f;
//int hornsgatan = 2;
//float sum = hornsgatan + gotgatan; // Om man ändrar variabeln "sum" till float så klarar kompilatorn av att lägga till en int-variabel. Och summan blir korrekt.
//Console.WriteLine($"Götgatan (antal km) + Hornsgatan (antal km) = {sum}");

//float gotgatan = 1.6f;
//float hornsgatan = 2;
//float sum = hornsgatan + gotgatan; // Om man ändrar alla variablarna till float klarar kompilatorn också att köra koden.
//Console.WriteLine($"Götgatan (antal km) + Hornsgatan (antal km) = {sum}");


float gotgatan = 1.6f, hornsgatan = 2f;
float sum = hornsgatan + gotgatan;
Console.WriteLine($"Götgatan {gotgatan}km + Hornsgatan {hornsgatan}km = {sum}km");
