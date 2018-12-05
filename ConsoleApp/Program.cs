using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace ConsoleApp
{
    class Program
    {
        private const string EncryptionKeyUrl = "https://rihandemocptug.vault.azure.net/keys/DemoEncryption";
        private const string EncryptionAlgorithm = "RSA-OAEP";
        private static async Task<string> GetToken(string authority, string resource, string scope)
        {
            var authContext = new AuthenticationContext(authority);
            var clientCred = new ClientCredential("notepad","notepad");
            var result = await authContext.AcquireTokenAsync(resource, clientCred);

            return result.AccessToken;
        }

        static void Main(string[] args)
        {
            using (var keyVault = new KeyVaultClient(GetToken))
            {

                var input = Console.ReadLine();
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var encryptedBytes = keyVault.EncryptAsync(EncryptionKeyUrl, EncryptionAlgorithm, inputBytes).Result.Result;

                var encryptedString = Encoding.ASCII.GetString(encryptedBytes);
                Console.WriteLine(encryptedString);

                var decryptedBytes = keyVault.DecryptAsync(EncryptionKeyUrl, EncryptionAlgorithm, encryptedBytes);
                var decryptedString = Encoding.ASCII.GetString(decryptedBytes.Result.Result);
                Console.WriteLine(decryptedString);

                Console.ReadLine();

            }

        }
    }
}
