using System;

namespace Sharpling.Business
{
    public abstract class BaseRepository
    {
        private readonly StarlingEnvironment _environment;

        protected BaseRepository(StarlingEnvironment environment)
        {
            _environment = environment;
        }

        protected Uri BaseEndpoint()
        {
            return _environment == StarlingEnvironment.SANDBOX ? new Uri("https://api-sandbox.starlingbank.com/api/v1/") : 
                                                                    new Uri("https://api.starlingbank.com/api/v1/");
        }
    }
}
