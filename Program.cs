internal class Program
    {

	static void Main(string[] args) 
	{
		string name;
		int nota =0;
		double media;

		console.writeLine("Digit your name: ");
		name = console.Realine();

		for (int i=1; i< nota.length; i++) {
			console.writeLine("Digit your nota: ");
			nota = int.parse(console.Realine());


		}
		media = nota[i] /4;
		console.writeLine($"{name} sua media é {media}");

	}
}