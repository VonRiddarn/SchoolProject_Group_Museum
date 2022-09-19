internal class Program
{
	public enum Room
	{
		Entry,
		Corridor_Lower,
		Corridor_Upper,
		Exhibit_West,
		Exhibit_North,
		Cafe,
		GiftShop
	};

	// Global scope answer variable
	static ConsoleKey answer = ConsoleKey.NoName;

	// Global scope current room
	static Room currentRoom = Room.Entry;

	public static void Main(string[] args)
	{
		// Mainframe loop - application lifecycle
		while (true)
		{
			if (currentRoom == Room.Entry)
			{
				EnterEntryRoomLoop();
			}
			else if (currentRoom == Room.Corridor_Lower)
			{
				CorridorLowerRoomLoop();
			}
			else if (currentRoom == Room.Corridor_Upper)
			{
				CorridorUpperRoomLoop();
			}
			else if (currentRoom == Room.Exhibit_West)
			{
				ExhibitWestRoomLoop();
			}
			else if (currentRoom == Room.Exhibit_North)
			{
				ExhibitNorthRoomLoop();
			}
			else if (currentRoom == Room.Cafe)
			{
				CafeRoomLoop();
			}
			else if (currentRoom == Room.GiftShop)
			{
				GiftshopRoomLoop();
			}
		}
	}

	public static void EnterEntryRoomLoop()
	{
		// Room loop
		while (true)
		{
			Console.Clear();

			Console.WriteLine("Du är i entren, vad vill du göra?\n");
			Console.WriteLine("1 : Gå in på Museét.");
			Console.WriteLine("2 : Gå hem\n");

			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				currentRoom = Room.Corridor_Lower;
				return;
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad1)
			{
				Console.WriteLine("Okej, du vet inte vad du missar.... n00b.");
				Console.WriteLine("Tryck på valfri tangent för att fortsätta.");
				Console.ReadKey();

				Environment.Exit(0);
			}

		}
	}

	public static void CorridorLowerRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Du är i nedredelen av korridoren, vad vill du göra?\n");
			Console.WriteLine("1 : Titta på cigarrer?"); 
			Console.WriteLine("2 : Titta på saltstatyerna?"); 
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå uppför korridoren?"); 
			Console.WriteLine("4 : Gå till entré?\n"); 
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				ShowObject("Här kan du se cigarrer, visst blir man röksugen?");
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				ShowObject("Saltstatyer, slicka helst inte på dom. Don't be salty.");
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				currentRoom = Room.Corridor_Upper;
				return;
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
				currentRoom = Room.Entry;
				return;
			}
		}
	}

	public static void CorridorUpperRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Du är i nedredelen av korridoren, här finns inget att titta på.");
			Console.WriteLine("Ska du fundera på livet eller fortsätta rundvandringen?\n");
			Console.WriteLine("1 : Du passerade precis en toalett, nödig?");
			Console.WriteLine("-----------------------------");
			Console.WriteLine("2 : Gå till utställningen i rum 1?"); 
			Console.WriteLine("3 : Gå till utställningen i rum 2?"); 
			Console.WriteLine("4 : Gå till cafeét?"); 
			Console.WriteLine("5 : Gå till nedre korridoren?\n"); 
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				ShowObject("Du orskade ett stopp i toaletten. Aktivera stealth-mode och smyg därifrån.");
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				currentRoom = Room.Exhibit_North;
				return;
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				currentRoom = Room.Exhibit_West;
				return;
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
				currentRoom = Room.Cafe;
				return;
			}
			else if (answer == ConsoleKey.D5 || answer == ConsoleKey.NumPad5)
			{
				currentRoom = Room.Corridor_Lower;
				return;
			}
		}
	}

	public static void ExhibitWestRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Du är i utställningsrum 2, vad vill du göra?\n");
			Console.WriteLine("1 : Titta på pipor?"); 
			Console.WriteLine("2 : Titta på bilder på Himalaya?"); 
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå tillbaka till korridoren?"); 
			Console.WriteLine("4 : Hoppa ut genom det stängda fönstret?\n"); 
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				ShowObject("Här kan du se pipor, inte PVC.");
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				ShowObject("Här är ett berg, det är gjort av sten.");
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				currentRoom = Room.Corridor_Upper;
				return;
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
				ShowObject("Om du skurit dig på glaset så säljer vi plåster i giftshopen.");

				Environment.Exit(0);
			}
		}
	}

	public static void ExhibitNorthRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Du är i utställningsrum 1, vad vill du göra?\n");
			Console.WriteLine("1 : Titta på saltvattenrenare?");
			Console.WriteLine("-----------------------------");
			Console.WriteLine("2 : Gå in på caféet?"); 
			Console.WriteLine("3 : Gå ut till korridoren?\n");
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				ShowObject("*stirrar* Det är mållöst vackert.");
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				currentRoom = Room.Cafe;
				return;
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				currentRoom = Room.Corridor_Upper;
				return;
			}
		}
	}

	public static void CafeRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Du är i caféet, vad vill du göra?\n");
			Console.WriteLine("1 : Köpa en kladdkaka?"); 
			Console.WriteLine("-----------------------------");
			Console.WriteLine("2 : Gå till giftshopen?");
			Console.WriteLine("3 : Gå till utställningen i rum 1?"); 
			Console.WriteLine("4 : Gå till korridoren?\n"); 
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				ShowObject("Tack för ditt köp. Den kommer skickas med postnord, förväntad mosad leverans om 2 månader.");
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				currentRoom = Room.GiftShop;
				return;
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				currentRoom = Room.Exhibit_North;
				return;
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
				currentRoom = Room.Corridor_Upper;
				return;
			}
		}
	}

	public static void GiftshopRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Du är i giftshopen, vad vill du göra?\n");
			Console.WriteLine("1 : Köpa ett husdjur?"); 
			Console.WriteLine("2 : Köpa något mer?"); 
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå till caféet?\n");
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				ShowObject("Tack för ditt köp, du kommer få en ovandrande pinne, vi borde verkligen ha satt lufthål i lådan.");
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				ShowObject("Behöver du plåster?");
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				currentRoom = Room.Cafe;
				return;
			}
		}
	}

	public static void ShowObject(string objectDescription)
	{
		Console.WriteLine(objectDescription);
		Console.WriteLine("Tryck valfri tangent för att fortsätta.");
		Console.ReadKey(true);
	}

}
