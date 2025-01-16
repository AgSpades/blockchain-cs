using NBitcoin;

Key privKey = new(); // Generate a random private key
PubKey pubKey = privKey.PubKey; // Derive the public key from the private key

var address = pubKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main);
Console.WriteLine($"Address: {address}");
Console.WriteLine($"Public key: {pubKey}");
Console.WriteLine($"Private key: {privKey.GetWif(Network.Main)}");