﻿using Bogus;
using PractiFly.DbEntities.Materials;
using PractiFly.FakerManager;

namespace Practifly.FakerGenerator.Faker.Materials;

public sealed class HeadingMaterialFaker : Faker<HeadingMaterial>, IFakerGenerate<HeadingMaterial>
{
    public HeadingMaterialFaker(string lang = "uk") : base(lang)
    {
        RuleFor(hm => hm.Id, f => f.IndexFaker + 1);
        RuleFor(hm => hm.HeadingId, f => f.RandomId());
        RuleFor(hm => hm.MaterialId, f => f.RandomId());
        RuleFor(hm => hm.Note, f => f.Lorem.Sentence());
    }
}