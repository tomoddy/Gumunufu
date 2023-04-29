using Gumunufu.Globals;

namespace Gumunufu.Objects
{
    /// <summary>
    /// Credential set
    /// </summary>
    internal class Credential
    {
        /// <summary>
        /// Username
        /// </summary>
        internal string? Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        internal string? Password { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="credentialMap">Credential map from firebase</param>
        public Credential(Dictionary<string, object> credentialMap)
        {
            Username = credentialMap[Resource.Firebase.USERNAME].ToString();
            Password = credentialMap[Resource.Firebase.PASSWORD].ToString();
        }
    }
}