﻿using Sitecore.MobileSDK.PublicKey;

namespace Sitecore.MobileSDK.CrudTasks
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using Sitecore.MobileSDK;
    using Sitecore.MobileSDK.Items;
    using Sitecore.MobileSDK.TaskFlow;
    using Sitecore.MobileSDK.PublicKey;

    public abstract class AbstractGetItemTask<TRequest> : IRestApiCallTasks<TRequest, HttpRequestMessage, string, ScItemsResponse>
    {
        private AbstractGetItemTask()
        {
        }

        public AbstractGetItemTask(HttpClient httpClient, ICredentialsHeadersCryptor credentialsHeadersCryptor)
        {
            this.httpClient = httpClient;
            this.credentialsHeadersCryptor = credentialsHeadersCryptor;

            this.Validate ();
        }

        #region  IRestApiCallTasks

        public async Task<HttpRequestMessage> BuildRequestUrlForRequestAsync(TRequest request)
        {
            string url = this.UrlToGetItemWithRequest(request);
            HttpRequestMessage result = new HttpRequestMessage(HttpMethod.Get, url);

            result = await this.credentialsHeadersCryptor.AddEncryptedCredentialHeadersAsync(result);
            return result;
        }

        public async Task<string> SendRequestForUrlAsync(HttpRequestMessage requestUrl)
        {
            HttpResponseMessage httpResponse = await this.httpClient.SendAsync(requestUrl);
            return await httpResponse.Content.ReadAsStringAsync();
        }

        public async Task<ScItemsResponse> ParseResponseDataAsync(string data)
        {
            Func<ScItemsResponse> syncParseResponse = () =>
            {
                return ScItemsParser.Parse(data);
            };
            return await Task.Factory.StartNew(syncParseResponse);
        }

        #endregion IRestApiCallTasks

        private void Validate()
        {
            if (null == this.httpClient)
            {
                throw new ArgumentNullException ("AbstractGetItemTask.httpClient cannot be null");
            }
            else if (null == this.credentialsHeadersCryptor)
            {
                throw new ArgumentNullException ("AbstractGetItemTask.credentialsHeadersCryptor cannot be null");
            }
        }

        protected abstract string UrlToGetItemWithRequest (TRequest request);


        private HttpClient httpClient;
        private ICredentialsHeadersCryptor credentialsHeadersCryptor;
    }
}



