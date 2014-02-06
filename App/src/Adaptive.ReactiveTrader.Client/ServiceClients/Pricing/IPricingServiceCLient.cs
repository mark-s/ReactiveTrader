﻿using System;
using Adaptive.ReactiveTrader.Contracts.Pricing;

namespace Adaptive.ReactiveTrader.Client.ServiceClients.Pricing
{
    public interface IPricingServiceClient
    {
        IObservable<Price> GetSpotStream(string currencyPair);
    }
}