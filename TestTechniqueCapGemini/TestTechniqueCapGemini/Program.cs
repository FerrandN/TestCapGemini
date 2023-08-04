using CallCenter;

List<string> listOfTowns = new List<string>();

listOfTowns.Add("Nice");
listOfTowns.Add("Cannes");
listOfTowns.Add("Fréjus");
listOfTowns.Add("Hyères");
listOfTowns.Add("Toulon");

Call call = new Call(listOfTowns);

Console.WriteLine("L'avion eteint le feu à Nice:\n");
call.CallReceived("Nice");
Console.WriteLine("\n");

Console.WriteLine("Les pompier eteignent le feu à Eydoche:\n");
call.CallReceived("Eydoche");
Console.WriteLine("\n");


Console.WriteLine("Les pompier dans le nouveau camion eteignent le feu à Lille:\n");
call.CallForNewVehicle("Lille");