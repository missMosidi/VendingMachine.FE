namespace VendigMachine.DataAccess.Responses.Commons
{
    public class ResultResponse<T>
    {
        public long TotalCount { get; set; }

        public T Item { get; set; }
    }
}