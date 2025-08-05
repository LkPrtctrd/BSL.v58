using BSL.v58.TitanEngine.NaCl;

namespace BSL.v58.TitanEngine.Pepp.Crypto;

public static class PepperKey
{
    static PepperKey()
    {
        ServerSecretKey = Convert.FromHexString("36abd74b2db5faa4d5a7977a1bc8be137ad7330efc934dfba36600ecd6871476");

        ServerPublicKey = TweetNaCl.CryptoScalarmultBase(ServerSecretKey);
    }

    public static byte[] ServerSecretKey { get; }
    public static byte[] ServerPublicKey { get; }
}