using CryptoWallet.Classes;

var fungibleAssetsList = new List<FungibleAsset>()
{
    new FungibleAsset(16955.48, "Bitcoin", "BTC"),
    new FungibleAsset(1257.4, "Ethereum", "ETH"),
    new FungibleAsset(1, "Tether", "USDT"),
    new FungibleAsset(287.53, "BNB", "BNB"),
    new FungibleAsset(13.73, "Solana", "SOL"),
    new FungibleAsset(5.48, "Polkadot", "DOT"),
    new FungibleAsset(79.87, "Litecoin", "LTC"),
    new FungibleAsset(0.9036, "Polygon", "MATIC"),
    new FungibleAsset(0.3185, "Cardano", "ADA"),
    new FungibleAsset(110.4, "Bitcoin Cash", "BCH")
};

var nonFungibleAssetsList = new List<NonFungibleAsset>()
{
    new NonFungibleAsset(fungibleAssetsList[1].Address, 0.075, "Sparky Teabop"),
    new NonFungibleAsset(fungibleAssetsList[1].Address, 0.799, "Wrapped MoonCats #6534"),
    new NonFungibleAsset(fungibleAssetsList[2].Address, 0.9999, "Wrapped MoonCats #7702"),
    new NonFungibleAsset(fungibleAssetsList[2].Address, 0.795, "Wrapped MoonCats #7405"),
    new NonFungibleAsset(fungibleAssetsList[5].Address, 0.55, "Wrapped MoonCats #3223"),
    new NonFungibleAsset(fungibleAssetsList[5].Address, 0.4, "Wrapped MoonCats #1960"),
    new NonFungibleAsset(fungibleAssetsList[6].Address, 0.599, "Wrapped MoonCats #795"),
    new NonFungibleAsset(fungibleAssetsList[6].Address, 0.53, "Wrapped MoonCats #7655"),
    new NonFungibleAsset(fungibleAssetsList[1].Address, 0.55, "Wrapped MoonCats #2612"),
    new NonFungibleAsset(fungibleAssetsList[5].Address, 1.99, "Wrapped MoonCats #6296"),
    new NonFungibleAsset(fungibleAssetsList[5].Address, 1.1999, "Wrapped MoonCats #7707"),
    new NonFungibleAsset(fungibleAssetsList[1].Address, 93.5, "Bored Ape Yacht Club #9930"),
    new NonFungibleAsset(fungibleAssetsList[3].Address, 95, "Bored Ape Yacht Club #1598"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 75.7895, "Bored Ape Yacht Club #3900"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 76.51, "Bored Ape Yacht Club #5221"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 77, "Bored Ape Yacht Club #4251"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 36.75, "Bored Ape Yacht Club #1741"),
    new NonFungibleAsset(fungibleAssetsList[7].Address, 42, "Bored Ape Yacht Club #3347"),
    new NonFungibleAsset(fungibleAssetsList[7].Address, 88.880, "Bored Ape Yacht Club #4271"),
    new NonFungibleAsset(fungibleAssetsList[3].Address, 3.5, "Disintegration"),
};

var bitcoinSupported = new List<Guid>() 
{ 
    fungibleAssetsList[0].Address,
    fungibleAssetsList[8].Address,
    fungibleAssetsList[9].Address
};

var ethereumSupported = new List<Guid>() 
{
    fungibleAssetsList[1].Address,
    fungibleAssetsList[2].Address,
    fungibleAssetsList[5].Address,
    fungibleAssetsList[6].Address,
};

for (var i = 0; i < 12; i++)
    ethereumSupported.Add(nonFungibleAssetsList[i].Address);

var solanaSupported = new List<Guid>() 
{
    fungibleAssetsList[3].Address,
    fungibleAssetsList[4].Address,
    fungibleAssetsList[7].Address
};

for (var i = 12; i < 20; i++)
    solanaSupported.Add(nonFungibleAssetsList[i].Address);

var walletsList = new List<Wallet>()
{
    new BitcoinWallet(bitcoinSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[0].Address, 5},
        {fungibleAssetsList[8].Address, 45.5}
    }),
    new BitcoinWallet(bitcoinSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[0].Address, 100},
        {fungibleAssetsList[9].Address, 15.3}
    }),
    new BitcoinWallet(bitcoinSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[9].Address, 12.85},
        {fungibleAssetsList[8].Address, 89}
    }),
    new EthereumWallet(ethereumSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[1].Address, 305},
        {fungibleAssetsList[2].Address, 28.45}
    }, new List<Guid>()
    {
        nonFungibleAssetsList[0].Address,
        nonFungibleAssetsList[4].Address,
        nonFungibleAssetsList[10].Address
    }),
    new EthereumWallet(ethereumSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[5].Address, 320.2},
        {fungibleAssetsList[6].Address, 5.7}
    }, new List<Guid>()
    {
        nonFungibleAssetsList[1].Address,
        nonFungibleAssetsList[2].Address
    }),
    new EthereumWallet(ethereumSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[1].Address, 5},
        {fungibleAssetsList[5].Address, 45.5},
        {fungibleAssetsList[6].Address, 38 }
    }, new List<Guid>()
    {
        nonFungibleAssetsList[3].Address,
        nonFungibleAssetsList[5].Address
    }),
    new SolanaWallet(solanaSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[3].Address, 2.3},
        {fungibleAssetsList[4].Address, 24.24}
    }, new List<Guid>()
    {
        nonFungibleAssetsList[12].Address,
        nonFungibleAssetsList[19].Address
    }),
    new SolanaWallet(solanaSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[4].Address, 121.1},
        {fungibleAssetsList[7].Address, 48.5}
    }, new List<Guid>()
    {
        nonFungibleAssetsList[13].Address,
        nonFungibleAssetsList[15].Address,
        nonFungibleAssetsList[17].Address
    }),
    new SolanaWallet(solanaSupported, new Dictionary<Guid, double>()
    {
        {fungibleAssetsList[3].Address, 44},
        {fungibleAssetsList[7].Address, 23}
    }, new List<Guid>()
    {
        nonFungibleAssetsList[14].Address
    }),
};

string StartMenu()
{
    Console.WriteLine("1 - Kreiraj wallet \n" +
                      "2 - Pristupi walletu \n" +
                      "0 - Izlazak iz aplikacije");

    var myOptions = new List<string>() { "0", "1", "2" };
    var myChoice = Input(myOptions);

    Console.Clear();
    return myChoice;
}

string Input(List<string> myOptions)
{
    var myChoice = Console.ReadLine().Trim().ToUpper();

    while (!myOptions.Contains(myChoice))
    {
        Console.WriteLine("Ta opcija ne postoji, pokusajte ponovno:");
        myChoice = Console.ReadLine().Trim().ToUpper();
    }

    return myChoice;
}

void ReturnToStartMenu()
{
    Console.WriteLine("\nP - Povratak na glavni menu \n" +
                        "0 - Izlazak iz aplikacije");

    var myChoice = Input(new List<string>() { "P", "0" });

    switch (myChoice)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Aplikacija zatvorena!");
            Environment.Exit(0);
            break;
        case "P":
            break;
    }
}

string myChoice;
do
{
    Console.Clear();
    myChoice = StartMenu();

    switch (myChoice)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Aplikacija zatvorena!");
            Environment.Exit(0);
            break;
        case "1":
            CreateWallet();
            break;
        case "2":
            AccessWallet();
            break;
    }
} while (true);

void CreateWallet()
{
    Console.WriteLine("1 - Bitcoin wallet \n" + 
                      "2 - Ethereum wallet \n" + 
                      "3 - Solana wallet \n" + 
                      "P - Povratak na glavni menu");

    var myOptions = new List<string> { "1", "2", "3", "P" };
    var myChoice = Input(myOptions);

    switch(myChoice)
    {
        case "1":
            CreateBitcoinWallet();
            break;
        case "2":
            CreateEthereumWallet();
            break;
        case "3":
            CreateSolanaWallet();
            break;
        case "P":
            break;
    }
}

bool ConfirmDialogue()
{
    Console.WriteLine("\nY - Zelim \n" +
                        "N - Ne zelim");
    var myChoice = Input(new List<string>() { "Y", "N" });

    return myChoice == "Y";
}

void CreateBitcoinWallet()
{
    Console.WriteLine("\nJeste li sigurni da zelite kreirati novi Bitcoin wallet?");

    if (!ConfirmDialogue())
        Console.WriteLine("\nRadnja zaustavljena!");
    else
    {
        var newWallet = new BitcoinWallet(bitcoinSupported, new Dictionary<Guid, double>());
        walletsList.Add(newWallet);
        Console.WriteLine("\nUspješno ste kreirali novi Bitcoin wallet!");
    }

    ReturnToStartMenu();
}

void CreateEthereumWallet()
{
    Console.WriteLine("\nJeste li sigurni da zelite kreirati novi Ethereum wallet?");

    if (!ConfirmDialogue())
        Console.WriteLine("\nRadnja zaustavljena!");
    else
    {
        var newWallet = new EthereumWallet(ethereumSupported, new Dictionary<Guid, double>(), new List<Guid>());
        walletsList.Add(newWallet);
        Console.WriteLine("\nUspješno ste kreirali novi Ethereum wallet!");
    }

    ReturnToStartMenu();
}

void CreateSolanaWallet()
{
    Console.WriteLine("\nJeste li sigurni da zelite kreirati novi Solana wallet?");

    if (!ConfirmDialogue())
        Console.WriteLine("\nRadnja zaustavljena!");
    else
    {
        var newWallet = new SolanaWallet(solanaSupported, new Dictionary<Guid, double>(), new List<Guid>());
        walletsList.Add(newWallet);
        Console.WriteLine("\nUspješno ste kreirali novi Solana wallet!");
    }

    ReturnToStartMenu();
}

void AccessWallet()
{

}