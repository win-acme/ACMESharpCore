using System;

namespace ACMESharp.Crypto.JOSE
{
    /// <summary>
    /// Defines the interface for a tool that provides the required
    /// JOSE Web Signature (JWS) functions as used by the ACME protocol.
    /// </summary>
    public interface IJwsTool : IDisposable
    {
        string JwsAlg { get; }

        void Init();

        string Export();

        void Import(string exported);

        string ExportEab();

        byte[] Sign(byte[] raw);

        bool Verify(byte[] raw, byte[] sig);
    }

    public interface IJwsTool<TJwk> : IJwsTool
    {
        TJwk ExportJwk();
    }

}
