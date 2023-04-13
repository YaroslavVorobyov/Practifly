using Bogus;
using PractiFly.DbEntities.Materials;
using PractiFly.FakerManager;

namespace Practifly.FakerGenerator.Faker.Materials;

public sealed class MaterialFaker : Faker<Material>, IFakerGenerate<Material>
{
    public MaterialFaker(string lang = "uk") : base(lang)
    {
        RuleFor(m => m.Id, f => f.IndexFaker + 1);
        RuleFor(m => m.Name, f => f.Name.FirstName());
        RuleFor(m => m.LanguageId, f => f.RandomId());
        RuleFor(m => m.Url, f => f.Internet.Url());
        RuleFor(m => m.IsPractical, f => f.Random.Bool());
        RuleFor(m => m.Note, f => f.Lorem.Sentence());
    }
}