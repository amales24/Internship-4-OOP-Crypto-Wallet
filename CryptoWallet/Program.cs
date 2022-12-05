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
    new NonFungibleAsset(fungibleAssetsList[3].Address, 1.1999, "Wrapped MoonCats #7707"),
    new NonFungibleAsset(fungibleAssetsList[3].Address, 3.5, "Disintegration"),
    new NonFungibleAsset(fungibleAssetsList[3].Address, 95, "Bored Ape Yacht Club #1598"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 75.7895, "Bored Ape Yacht Club #3900"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 76.51, "Bored Ape Yacht Club #5221"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 77, "Bored Ape Yacht Club #4251"),
    new NonFungibleAsset(fungibleAssetsList[4].Address, 36.75, "Bored Ape Yacht Club #1741"),
    new NonFungibleAsset(fungibleAssetsList[7].Address, 42, "Bored Ape Yacht Club #3347"),
    new NonFungibleAsset(fungibleAssetsList[7].Address, 88.880, "Bored Ape Yacht Club #4271"),
    new NonFungibleAsset(fungibleAssetsList[1].Address, 93.5, "Bored Ape Yacht Club #9930"),
};