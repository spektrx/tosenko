public class GetPersonResponse
{
	public Person Person { get; }

	public GetPersonResponse(Person person)
	{
		Person = person;
	}
};