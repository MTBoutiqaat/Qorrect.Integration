﻿using Qorrect.Integration.Helper;
using System;
using System.Collections.Generic;

namespace Qorrect.Integration.Models
{
    public class DTOExternalApiCourse
    {
        public List<DTOCourses> courses { get; set; }
    }

    public class DTOCourses
    {
        public string fullname { get; set; }
        public string shortname { get; set; }
        public int categoryid { get; set; }
        public string summary { get; set; }
        public string categoryname { get; set; }

    }

    public class DTOAddEditCourse
    {
        public Guid? Id { get; set; }
       public string Code { get; set; }
        public string Name { get; set; }
        public Guid? CourseSubscriptionId { get; set; }
        public DTOCourseData CourseData { get; set; }
    }

    public class DTOCourseData
    {
        public CourseType? CourseType { get; set; }
        public int? CreditHours { get; set; }
        public int? LecturesHours { get; set; }
        public int? PracticalHours { get; set; }
        public string Description { get; set; }
        public double? TotalMarks { get; set; }
        public double? TotalHours { get; set; }
        public List<DTOLevelCourseDataTag> Tags { get; set; }
        public bool IsValidTotalMarks { get { return (TotalMarks == null || TotalMarks >= 0); } }
        public bool IsValidTotalHours { get { return (TotalHours == null || TotalHours >= 0); } }
    }

    public class DTOLevelCourseDataTag
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
    }

    public class DTOBedoCourse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CreditHours { get; set; }
        public int PracticalHours { get; set; }
        public int ClassesHours { get; set; }
        public int LectureHours { get; set; }
        public int LevelID { get; set; }
        public string Description { get; set; }
    }
}
