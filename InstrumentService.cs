﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using testapp.Models;

namespace testapp
{
    class InstrumentService
    {
        public InstrumentList GetInstrumentList()
        {
            var uri = "https://api-fxpractice.oanda.com/v3/accounts/101-002-14835452-002/instruments";
            var restClient = new RestClient(uri);
            var restRequest = new RestRequest();
            restRequest.Method = RestSharp.Method.GET;
            restRequest.AddHeader("Authorization", "Bearer 551cb19f4a836f950717a0202b8dde87-adad3a86ed84c81861f9b947c435220c");
            var response = restClient.Execute(restRequest);
            return JsonConvert.DeserializeObject<InstrumentList>(response.Content);

        }
    }
}

