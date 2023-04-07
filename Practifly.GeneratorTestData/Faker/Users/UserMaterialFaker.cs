using Bogus;
using PractiFly.Tests.EntityFromDb;
using PractiFly.WebApi.EntityDb.Users;

namespace Practifly.GeneratorTestData.Faker.Users;

public sealed class UserMaterialFaker: Faker<UserMaterial>, IFakerGenerate<UserMaterial>
{
    public UserMaterialFaker(string lang = "uk") : base(lang)
    {
        RuleFor(um => um.UserId, f => f.RandomId());
        RuleFor(um => um.MaterialId, f => f.RandomId());
        RuleFor(um => um.IsCompleted, f => f.Random.Bool());
        RuleFor(um => um.ResultUrl, f => f.Internet.Url());
        RuleFor(um => um.Grade, f => f.Random.Int(0, 100));
        RuleFor(um => um.Note, f => f.Lorem.Sentence());
    }
}