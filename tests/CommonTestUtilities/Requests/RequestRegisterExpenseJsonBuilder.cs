﻿using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests;

public static class RequestRegisterExpenseJsonBuilder
{
    public static RequestExpenseJson Build()
    {
        var faker = new Faker();

        return new Faker<RequestExpenseJson>()
            .RuleFor(r => r.Title, f => f.Commerce.ProductName())
            .RuleFor(r => r.Description, f => f.Commerce.ProductDescription())
            .RuleFor(r => r.Date, f => f.Date.Past())
            .RuleFor(r => r.PaymentType, f => f.PickRandom<PaymentType>())
            .RuleFor(r => r.Amount, f => f.Random.Decimal(min: 1, max: 1000));
    }
}
