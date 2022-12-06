using CryptoWallet;
using CryptoWallet.Classes;

Globals.fungibleAssetsList = new List<FungibleAsset>()
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

Globals.nonFungibleAssetsList = new List<NonFungibleAsset>()
{
    new NonFungibleAsset(Globals.fungibleAssetsList[1].Address, 0.075, "Sparky Teabop"),
    new NonFungibleAsset(Globals.fungibleAssetsList[1].Address, 0.799, "Wrapped MoonCats #6534"),
    new NonFungibleAsset(Globals.fungibleAssetsList[2].Address, 0.9999, "Wrapped MoonCats #7702"),
    new NonFungibleAsset(Globals.fungibleAssetsList[2].Address, 0.795, "Wrapped MoonCats #7405"),
    new NonFungibleAsset(Globals.fungibleAssetsList[5].Address, 0.55, "Wrapped MoonCats #3223"),
    new NonFungibleAsset(Globals.fungibleAssetsList[5].Address, 0.4, "Wrapped MoonCats #1960"),
    new NonFungibleAsset(Globals.fungibleAssetsList[6].Address, 0.599, "Wrapped MoonCats #795"),
    new NonFungibleAsset(Globals.fungibleAssetsList[6].Address, 0.53, "Wrapped MoonCats #7655"),
    new NonFungibleAsset(Globals.fungibleAssetsList[1].Address, 0.55, "Wrapped MoonCats #2612"),
    new NonFungibleAsset(Globals.fungibleAssetsList[5].Address, 1.99, "Wrapped MoonCats #6296"),
    new NonFungibleAsset(Globals.fungibleAssetsList[5].Address, 1.1999, "Wrapped MoonCats #7707"),
    new NonFungibleAsset(Globals.fungibleAssetsList[1].Address, 93.5, "Bored Ape Yacht Club #9930"),
    new NonFungibleAsset(Globals.fungibleAssetsList[3].Address, 95, "Bored Ape Yacht Club #1598"),
    new NonFungibleAsset(Globals.fungibleAssetsList[4].Address, 75.7895, "Bored Ape Yacht Club #3900"),
    new NonFungibleAsset(Globals.fungibleAssetsList[4].Address, 76.51, "Bored Ape Yacht Club #5221"),
    new NonFungibleAsset(Globals.fungibleAssetsList[4].Address, 77, "Bored Ape Yacht Club #4251"),
    new NonFungibleAsset(Globals.fungibleAssetsList[4].Address, 36.75, "Bored Ape Yacht Club #1741"),
    new NonFungibleAsset(Globals.fungibleAssetsList[7].Address, 42, "Bored Ape Yacht Club #3347"),
    new NonFungibleAsset(Globals.fungibleAssetsList[7].Address, 88.880, "Bored Ape Yacht Club #4271"),
    new NonFungibleAsset(Globals.fungibleAssetsList[3].Address, 3.5, "Disintegration"),
};

Globals.allAssetsList = Globals.fungibleAssetsList.ConvertAll(x => (Asset)x);
Globals.allAssetsList.AddRange(Globals.nonFungibleAssetsList);

Globals.bitcoinSupported = new List<Guid>() 
{ 
    Globals.fungibleAssetsList[0].Address,
    Globals.fungibleAssetsList[8].Address,
    Globals.fungibleAssetsList[9].Address
};

Globals.ethereumSupported = new List<Guid>() 
{
    Globals.fungibleAssetsList[1].Address,
    Globals.fungibleAssetsList[2].Address,
    Globals.fungibleAssetsList[5].Address,
    Globals.fungibleAssetsList[6].Address,
};

for (var i = 0; i < 12; i++)
    Globals.ethereumSupported.Add(Globals.nonFungibleAssetsList[i].Address);

Globals.solanaSupported = new List<Guid>() 
{
    Globals.fungibleAssetsList[3].Address,
    Globals.fungibleAssetsList[4].Address,
    Globals.fungibleAssetsList[7].Address
};

for (var i = 12; i < 20; i++)
    Globals.solanaSupported.Add(Globals.nonFungibleAssetsList[i].Address);

Globals.walletsList = new List<Wallet>()
{
    new BitcoinWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[0].Address, 5},
        {Globals.fungibleAssetsList[8].Address, 45.5}
    }),
    new BitcoinWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[0].Address, 100},
        {Globals.fungibleAssetsList[9].Address, 15.3}
    }),
    new BitcoinWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[9].Address, 12.85},
        {Globals.fungibleAssetsList[8].Address, 89}
    }),
    new EthereumWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[1].Address, 305},
        {Globals.fungibleAssetsList[2].Address, 28.45}
    }, new List<Guid>()
    {
        Globals.nonFungibleAssetsList[0].Address,
        Globals.nonFungibleAssetsList[4].Address,
        Globals.nonFungibleAssetsList[10].Address
    }),
    new EthereumWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[5].Address, 320.2},
        {Globals.fungibleAssetsList[6].Address, 5.7}
    }, new List<Guid>()
    {
        Globals.nonFungibleAssetsList[1].Address,
        Globals.nonFungibleAssetsList[2].Address
    }),
    new EthereumWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[1].Address, 5},
        {Globals.fungibleAssetsList[5].Address, 45.5},
        {Globals.fungibleAssetsList[6].Address, 38 }
    }, new List<Guid>()
    {
        Globals.nonFungibleAssetsList[3].Address,
        Globals.nonFungibleAssetsList[5].Address
    }),
    new SolanaWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[3].Address, 2.3},
        {Globals.fungibleAssetsList[4].Address, 24.24}
    }, new List<Guid>()
    {
        Globals.nonFungibleAssetsList[12].Address,
        Globals.nonFungibleAssetsList[19].Address
    }),
    new SolanaWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[4].Address, 121.1},
        {Globals.fungibleAssetsList[7].Address, 48.5}
    }, new List<Guid>()
    {
        Globals.nonFungibleAssetsList[13].Address,
        Globals.nonFungibleAssetsList[15].Address,
        Globals.nonFungibleAssetsList[17].Address
    }),
    new SolanaWallet(new Dictionary<Guid, double>()
    {
        {Globals.fungibleAssetsList[3].Address, 44},
        {Globals.fungibleAssetsList[7].Address, 23}
    }, new List<Guid>()
    {
        Globals.nonFungibleAssetsList[14].Address
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
    var myChoice = Console.ReadLine().Trim().ToLower();

    while (!myOptions.Contains(myChoice))
    {
        Console.WriteLine("\nTa opcija ne postoji, pokusajte ponovno:");
        myChoice = Console.ReadLine().Trim().ToLower();
    }

    return myChoice;
}

void ReturnToStartMenu()
{
    Console.WriteLine("\nP - Povratak na glavni menu \n" +
                        "0 - Izlazak iz aplikacije");

    var myChoice = Input(new List<string>() { "p", "0" });

    switch (myChoice)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Aplikacija zatvorena!");
            Environment.Exit(0);
            break;
        case "p":
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

    var myOptions = new List<string> { "1", "2", "3", "p" };
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
        case "p":
            break;
    }
}

bool ConfirmDialogue()
{
    Console.WriteLine("\nY - Zelim \n" +
                        "N - Ne zelim");
    var myChoice = Input(new List<string>() { "y", "n" });

    return myChoice == "y";
}

void CreateBitcoinWallet()
{
    Console.WriteLine("\nJeste li sigurni da zelite kreirati novi Bitcoin wallet?");

    if (!ConfirmDialogue())
        Console.WriteLine("\nRadnja zaustavljena!");
    else
    {
        var newWallet = new BitcoinWallet(new Dictionary<Guid, double>());
        Globals.walletsList.Add(newWallet);
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
        var newWallet = new EthereumWallet(new Dictionary<Guid, double>(), new List<Guid>());
        Globals.walletsList.Add(newWallet);
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
        var newWallet = new SolanaWallet(new Dictionary<Guid, double>(), new List<Guid>());
        Globals.walletsList.Add(newWallet);
        Console.WriteLine("\nUspješno ste kreirali novi Solana wallet!");
    }

    ReturnToStartMenu();
}

void AccessWallet()
{
    Console.WriteLine("Popis svih dostupnih walleta: \n");

    foreach (var wallet in Globals.walletsList)
    {
        wallet.PrintWalletInfo();
        wallet.SetValueBefore();
    }

    Console.WriteLine("Unesite adresu walleta kojem zelite pristupiti:");
    var myWallet = InputWalletAddress();

    Console.Clear();
    Portfolio(myWallet);

    Console.WriteLine("1 - Transfer \n" +
        "2 - Povijest transakcija \n" +
        "P - Povratak na glavni menu");

    var myOptions = new List<string>() { "1", "2", "p" };
    var myChoice = Input(myOptions);

    switch(myChoice)
    {
        case "1":
            Transfer(myWallet);
            break;
        case "2":
            Console.Clear();
            break;
        case "p":
            break;
    }
}

Wallet InputWalletAddress()
{
    var myWalletAddress = Console.ReadLine().Trim();
    Wallet myWallet;

    while (true)
    {
        myWallet = Globals.walletsList.Find(w => w.Address.ToString() == myWalletAddress);

        if (myWallet == null)
        {
            Console.WriteLine("\nWallet s tom adresom ne postoji, pokusajte ponovno:");
            myWalletAddress = Console.ReadLine().Trim();
        }
        else
            break;
    }

    return myWallet;
}

void Portfolio(Wallet myWallet)
{
    Console.WriteLine("Uspjesno ste pristupili zeljenom walletu, ovdje mozete vidjeti njegovo stanje:\n");

    if (myWallet.GetTotalAssetValue() == 0)
    {
        Console.WriteLine("Wallet je prazan!");
        return;
    }

    myWallet.PrintPortfolio();
}

void Transfer(Wallet myWallet)
{
    Console.WriteLine("Unesite adresu walleta kojem zelite poslati asset. Dolje možete vidjeti sve opcije:");

    var myOptions = new List<string>();

    foreach (var wallet in Globals.walletsList)
    {
        if (wallet.Address != myWallet.Address)
        {
            Console.WriteLine($"> {wallet.Address}, {wallet.GetWalletType()} wallet");
            myOptions.Add(wallet.Address.ToString());
        }
    }
    Console.WriteLine();

    var recipientAddress = Input(myOptions);
    var recipientWallet = Globals.walletsList.Find(w => w.Address.ToString() == recipientAddress);

    Console.WriteLine("\nUnesite adresu asseta kojeg zelite poslati:");
    var myAssetOptions = myWallet.GetAllAssetAddresses();
    var myAssetAddress = Input(myAssetOptions.ConvertAll(x => x.ToString()));

    if (!recipientWallet.SupportedAssets.Contains(Guid.Parse(myAssetAddress)))
    {
        Console.WriteLine("\nNovcanik koji ste odabrali ne podrzava asset koji mu zelite poslati!");
        ReturnToStartMenu();
        return;
    }

    var myAsset = Globals.allAssetsList.Find(a => a.Address == Guid.Parse(myAssetAddress));

    if (myAsset.IsFungible())
    {
        FungibleTransfer(myWallet, recipientWallet, myAsset);
    }
    else
        NonFungibleTransfer(myWallet, recipientWallet, myAsset);

    ReturnToStartMenu();
}

double InputAmount()
{
    var myAmountString = Console.ReadLine().Trim();
    double myAmount;

    while(true)
    {
        try
        {
            myAmount = double.Parse(myAmountString);

            if (myAmount <= 0)
            {
                Console.WriteLine("Kolicina mora biti pozitivna, pokusajte ponovno:");
                myAmountString = Console.ReadLine().Trim();
            }

            return myAmount;
        }
        catch
        {
            Console.WriteLine("\nPogresan unos, pokusajte ponovno: ");
            myAmountString = Console.ReadLine().Trim();
        }
    }
}

void FungibleTransfer(Wallet myWallet, Wallet recipientWallet, Asset myAsset)
{
    Console.WriteLine("\nUnesite kolicinu asseta koju zelite prebaciti: ");
    var myAmount = InputAmount();

    if (myAmount > myWallet.GetMyFungibleAssetValue(myAsset))
    {
        Console.WriteLine("\nStanje na racunu nije dovoljno za izvrsiti transakciju!");
        return;
    }

    Console.WriteLine("\nJeste li sigurni da zelite izvrsiti transakciju?");

    if (!ConfirmDialogue())
    {
        Console.WriteLine("Radnja zaustavljena!");
        return;
    }

    myWallet.ChangeAssetBalance(myAsset.Address, - myAmount);
    recipientWallet.ChangeAssetBalance(myAsset.Address, myAmount);

    var myFungibleTransaction = new FungibleTransaction(myAsset.Address, DateTime.Now, myWallet.Address, recipientWallet.Address);
    myWallet.TransactionAddresses.Add(myFungibleTransaction.Id);
    recipientWallet.TransactionAddresses.Add(myFungibleTransaction.Id);

    var random = new Random();
    var rDouble = random.NextDouble();
    var upperBound = -2.5;
    var lowerBound = 2.5;
    var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;

    myAsset.ChangeAssetValueInUSD(rRangeDouble);
}

void NonFungibleTransfer(Wallet myWallet, Wallet recipientWallet, Asset myAsset)
{
    Console.WriteLine("\nJeste li sigurni da zelite izvrsiti transakciju?");

    if (!ConfirmDialogue())
    {
        Console.WriteLine("Radnja zaustavljena!");
        return;
    }

    NonFungibleAsset myNonFungibleAsset = (NonFungibleAsset)myAsset;

}