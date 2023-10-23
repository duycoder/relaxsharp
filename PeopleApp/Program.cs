﻿using Packt.Shared;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;


//WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}", arg0: bob.Name, arg1: bob.DateOfBirth);

WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}", arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

//WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");


bob.Children.Add(new Person() { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

//WriteLine($"{bob.Name} has {bob.Children.Count} children");

//for (int i = 0; i < bob.Children.Count; i++)
//{
//    WriteLine($"> {bob.Children[i].Name}");
//}


//WriteLine($"{bob.Name} is a {Person.Species}");

//Person alice = new()
//{
//    Name = "Alice Jones",
//    DateOfBirth = new DateTime(1998, 3, 7)
//};
//WriteLine(format: "{0} was born on {1:dd MMM yy}", arg0: alice.Name, arg1: alice.DateOfBirth);


//BankAccount.InterestRate = 0.012M;

//BankAccount jonesAccount = new()
//{
//    AccountName = "Mrs. Jones",
//    Balance = 2400
//};

//WriteLine(format: "{0} earned {1:C} interest.", arg0: jonesAccount.AccountName, arg1: jonesAccount.Balance * BankAccount.InterestRate);


//BankAccount gerrierAccount = new()
//{
//    AccountName = "Mrs. Gerrier",
//    Balance = 98
//};

//WriteLine(format: "{0} earned {1:C} interest.", arg0: gerrierAccount.AccountName, arg1: gerrierAccount.Balance);


//WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

//Person blankPerson = new();

//WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on {2:dddd}",
//    arg0: blankPerson.Name,
//    arg1: blankPerson.HomePlanet,
//    arg2: blankPerson.Instantiated);

//Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

//WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}", 
//    arg0: gunny.Name, 
//    arg1: gunny.HomePlanet, 
//    arg2: gunny.Instantiated);

//bob.WriteToConsole();
//WriteLine(bob.GetOrigin());

//(string, int) fruit = bob.GetFruit();

//WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

//var fruitNamed = bob.GetNamedFruit();
//WriteLine($"There are {fruitNamed.Name} {fruitNamed.Number}");

//var thing1 = ("Neville", 4);
//WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

//var thing2 = (bob.Name, bob.Children.Count);
//WriteLine($"{thing2.Name} has {thing2.Count} children.");

//(string fruitName, int fruitNumber) = bob.GetFruit();
//WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");


//var (name1, dob1) = bob;
//WriteLine($"Deconstructed: {name1}, {dob1}");

//var (name2, dob2, fav2) = bob;
//WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

//WriteLine(bob.OptinalParameters("Jump!", 98.5));

//WriteLine(bob.OptinalParameters(number: 52.7, command: "Hide!"));

//WriteLine(bob.OptinalParameters("Poke!", active: false));

//int a = 10;
//int b = 20;
//int c = 30;
//WriteLine($"Before: a = {a}, b = {b}, c = {c}");
//bob.PassingParameters(a, ref b, out c);
//WriteLine($"After: a = {a}, b = {b}, c = {c}");

//int d = 10;
//int e = 20;
//WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");

int d = 10;
int e = 20;

bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");
