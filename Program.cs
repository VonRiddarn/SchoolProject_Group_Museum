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

			Console.WriteLine("Du är i entren, vad vill du göra?");
			Console.WriteLine("1 : Gå in på Museét.");
			Console.WriteLine("2 : Gå hem");

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
			Console.WriteLine("1 : Titta på cigaretterna?"); // titta på verk
			Console.WriteLine("2 : Titta på saltstatyerna?"); // titta på verk
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå uppför korridoren?"); // move along
			Console.WriteLine("4 : Gå till entré?"); // move along
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
				// beskrivning av cigaretterna?
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
				// beskrivning av saltstatyerna?
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
				// kalla på metoden CorridorLowerRoomLoop()
				currentRoom = Room.Corridor_Upper;
				return;
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
				// kalla på metoden EnterEntryRoomLoop()
			}
		}
	}

	public static void CorridorUpperRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Här finns inget att titta på. Ska du fundera på livet eller fortsätta rundvandringen?");
			Console.WriteLine("1 : Du passerade precis en toalett, nödig?"); // titta på verk
			Console.WriteLine("-----------------------------");
			Console.WriteLine("2 : Gå till utställningen i rum 1?"); // move along
			Console.WriteLine("3 : Gå till utställningen i rum 2?"); // move along
			Console.WriteLine("4 : Gå till cafeét?"); // move along
			Console.WriteLine("4 : Gå till nedre korridoren?"); // move along
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
			}
			else if (answer == ConsoleKey.D5 || answer == ConsoleKey.NumPad5)
			{
			}
		}
	}

	public static void ExhibitWestRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("1 : Titta på pipor?"); // titta på verk
			Console.WriteLine("2 : Titta på bilder på Himalaya?"); // titta på verk
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå tillbaka till korridoren?"); // move along
			Console.WriteLine("4 : Hoppa ut genom det stängda fönstret?"); // move along
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
			}
		}
	}

	public static void ExhibitNorthRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("1 : Titta på saltvattenrenare?"); // titta på verk
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå in på caféet?"); // move along
			Console.WriteLine("4 : Gå ut till korridoren?"); // move along
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
			}
		}
	}

	public static void CafeRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("1 : Köp en kladdkaka?"); // titta på verk
			Console.WriteLine("-----------------------------");
			Console.WriteLine("2 : Gå till giftshopen?"); // move along
			Console.WriteLine("3 : Gå till utställningen i rum 1?"); // move along
			Console.WriteLine("4 : Gå till korridoren?"); // move along
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
			}
		}
	}

	public static void GiftshopRoomLoop()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("1 : Köp ett husdjur?"); // titta på verk
			Console.WriteLine("2 : Köpa något mer??"); // har vi ett annat förslag?
			Console.WriteLine("-----------------------------");
			Console.WriteLine("3 : Gå till caféet?"); // move along
			answer = Console.ReadKey(true).Key;


			if (answer == ConsoleKey.D1 || answer == ConsoleKey.NumPad1)
			{
			}
			else if (answer == ConsoleKey.D2 || answer == ConsoleKey.NumPad2)
			{
			}
			else if (answer == ConsoleKey.D3 || answer == ConsoleKey.NumPad3)
			{
			}
			else if (answer == ConsoleKey.D4 || answer == ConsoleKey.NumPad4)
			{
			}
		}
	}

}
