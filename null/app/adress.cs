public class Address
{
	public string Street { get; }
	public int Number { get; }

	public Address(string street, int number)
	{
		Street = street;
		Number = number;
	}
}
