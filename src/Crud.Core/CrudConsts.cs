using Crud.Debugging;

namespace Crud
{
    public class CrudConsts
    {
        public const string LocalizationSourceName = "Crud";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9ff2742e072a4abf92f3c4cb5a1afb7a";
    }
}
