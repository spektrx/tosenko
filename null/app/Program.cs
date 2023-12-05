// GetPersonResponse getPersonResponse = new(new Person(new Workplace(new Address("nhfcg gjvjhg",78))));

// string? street = getPersonResponse?.Person?.Workplace?.Address?.Street;

// if (street is not null)
// {
//     Console.WriteLine(getPersonResponse.Person.Workplace.Address.Street);
// }
// else
// {
//     Console.WriteLine("No work address available");
// }


//Исправить **if** в функции *Main()*, чтобы там не было операций **&&**

// class Program {
//  static String location;
//  static DateTime? time = null;

//  static void Main() {
//    Console.WriteLine(location == null ? "location is null" : location);
//    Console.WriteLine(time == null ? "time is null" : time.ToString());
//  }
// }
using System.Reflection.Metadata.Ecma335;
int[] arr = {};
int func(int[] arr) => arr is not null ? arr.Sum() : 0;

int a = func(arr);
Console.WriteLine(a);