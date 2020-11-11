namespace VendigMachine.DataAccess.Utilities
{
    public static class EndPointRoutesParams
    {

        public const string GETALL = "";

        public const string GET_BY_ID  = "";

        public const string CREATE = "";

        public const string UPDATE  = "/";

        public const string DELETE = "/";

        public const string RESTORE  = "/Restore/";

        public const string GET_DELETED = "/Deleted";

        public const string GET_BY_STATUS_CODE = "/By/StatusCode/";

        public const string GET_BY_STATUS_ID = "/By/Status/";

        public const string GET_BY_ACTIVE_STATUS = "/By/Active/Status/";

        public const string Authenticate = "/Authenticate";

        public const string SignOff = "/SignOff";

        public const string GetExternalAuthenticationProviders = "/GetExternalAuthenticationProviders";

        public const string ExternalAuthenticate = "/ExternalAuthenticate";

        public const string GetCurrentPerson = "/Current/Person";

        public const string GetCurrentPersonAddress = "/Current/Person/Addresses";

        public const string GetCurrentPersonContact = "/Current/Person/Contacts";

        public const string GetCurrentUserImage = "/Current/UserImage";
    }
}
