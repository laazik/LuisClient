namespace Ee.Rockit.LuisClient.Model
{
    public class RequestDTO
    {
        public string AppId { get; internal set; }

        public string Query { get; internal set; }

        public decimal? TimezoneOffset { get; internal set; }

        public bool? Verbose { get; internal set; }

        public bool? SpellCheck { get; internal set; }

        public bool? Staging { get; internal set; }

        public RequestDTO(
            string query,
            string appId = null,
            decimal timezoneOffset = 0, 
            bool? verbose = null,
            bool? spellCheck = null, 
            bool? staging = null)
        {
            Query = query;
            AppId = appId;
            TimezoneOffset = timezoneOffset;
            Verbose = verbose;
            SpellCheck = spellCheck;
            Staging = staging;
        }
    }
}
