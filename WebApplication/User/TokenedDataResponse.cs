namespace Data
{
    public abstract class TokenedDataResponse<TQueryResult> : DataResponse<TQueryResult>, IHasTokenData
    {
        protected TokenedDataResponse()
        {
        }

        protected TokenedDataResponse(TokenData tokenData)
        {
            Token = tokenData;
        }

        protected TokenedDataResponse(TQueryResult query)
            : base(query)
        {
            Token = null;
        }

        protected TokenedDataResponse(TokenData tokenData, TQueryResult queryResult)
            : base(queryResult)
        {
            Token = tokenData;
        }

        public TokenData Token { get; set; }
    }
}