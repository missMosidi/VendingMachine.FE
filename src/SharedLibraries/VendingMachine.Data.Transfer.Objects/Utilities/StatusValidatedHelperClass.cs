using VendingMachine.Data.Transfer.Objects.Enums;

namespace VendingMachine.Data.Transfer.Objects.Utilities
{
    public static class StatusValidatedHelperClass
    {
        public static bool ValiodateVisablity(StatusCode input) =>
            input == StatusCode.Published ||
            input == StatusCode.Active ||
            input == StatusCode.Complete ||
            input == StatusCode.Approved;
    }
}
