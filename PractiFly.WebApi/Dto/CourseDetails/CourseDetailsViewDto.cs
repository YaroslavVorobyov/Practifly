﻿namespace PractiFly.WebApi.Dto.CourseDetails
{
    //інфо, перегляд
    public class CourseDetailsViewDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Url { get; set; } = null!;
        public int? Grade { get; set; }
    }
}