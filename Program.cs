using NBitcoin;

Key privKey = new(); // Generate a random private key
PubKey pubKey = privKey.PubKey; // Derive the public key from the private key

Console.WriteLine($"Private key: {privKey.GetWif(Network.TestNet)}");
Console.WriteLine($"Public key: {pubKey}");

// We will use the key to create a P2PKH address
var address = pubKey.GetAddress(ScriptPubKeyType.Legacy, Network.TestNet);
Console.WriteLine($"Address: {address}");