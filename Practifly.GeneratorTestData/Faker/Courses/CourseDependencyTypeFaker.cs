using Bogus;
using PractiFly.WebApi.EntityDb.Courses;

namespace PractiFly.Tests.EntityFromDb;

public sealed class CourseDependencyTypeFaker : Faker<CourseDependencyType>, IFakerGenerate<CourseDependencyType>
{
    public CourseDependencyTypeFaker()
    {
        RuleFor(cdt => cdt.Id, f => f.IndexFaker + 1);
        RuleFor(cdt => cdt.Name, f => f.Lorem.Word());
        RuleFor(cdt => cdt.Note, f => f.Lorem.Sentence());
        RuleFor(cdt => cdt.Description, f => f.Lorem.Sentence());
    }
}