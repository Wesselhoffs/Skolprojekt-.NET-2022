ThreeSecondMethod();
TenSecondMethod();

Console.ReadKey();




async void ThreeSecondMethod()
{
    Console.WriteLine("Starting 3 second method.");
    await Task.Delay(3000);
    Console.WriteLine("3 second method finished.");
}



async void TenSecondMethod()
{
    Console.WriteLine("Starting 10 second method.");
    await Task.Delay(10000);
    Console.WriteLine("10 second method finished.");
}
