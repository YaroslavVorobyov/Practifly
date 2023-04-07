using Bogus;
using PractiFly.Tests.EntityFromDb;
using PractiFly.WebApi.EntityDb.Users;

namespace Practifly.GeneratorTestData.Faker.Users;

public sealed class UserCourseFaker: Faker<UserCourse>, IFakerGenerate<UserCourse>
{
    public UserCourseFaker(string lang = "uk") : base(lang)
    {
        RuleFor(uc => uc.UserId, f => f.RandomId());
        RuleFor(uc => uc.CourseId, f => f.RandomId());
        RuleFor(uc => uc.LevelId, f => f.RandomId());
        RuleFor(uc => uc.IsCompleted, f => f.Random.Bool());
        RuleFor(uc => uc.LastTime, f => f.Date.Past());
        RuleFor(uc => uc.LastThemeId, f => f.RandomId());
        RuleFor(uc => uc.Grade, f => f.Random.Int(0, 100));
        RuleFor(uc => uc.Note, f => f.Lorem.Sentence());
    }
}