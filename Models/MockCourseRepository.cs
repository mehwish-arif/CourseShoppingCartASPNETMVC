using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouseCatalogueMVC.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository categoryRepository;

        public MockCourseRepository(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }
        public IEnumerable<Course> AllCourses => new List<Course>
        {
            new Course {
            CourseId = 1, Title = "ASP.NET Core ", Description = "ASP.NET is a popular web-development framework for building web apps on the .NET platform.",
            Fee = 1350, isWeekendClassAvailable = true, ImageUrl ="https://exerevno.com/wp-content/uploads/2017/07/asp.net_.png",
            Category = categoryRepository.AllCategories.ToList()[0]
            },

            new Course {
            CourseId = 2, Title = "MEAN Stack", Description = "A relatively new stack, MEAN stands for MongoDB, Express.js, AngularJS, and Node.js.",
            Fee = 200, isWeekendClassAvailable = true, ImageUrl ="https://codingthesmartway.com/wp-content/uploads/2018/06/mean_logo.png",
            Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course {
             CourseId = 3, Title = "MERN Stack", Description = "MERN Stack is a Javascript Stack that is used for easier and faster deployment of full-stack web applications.",
            Fee = 2000, isWeekendClassAvailable = true, ImageUrl ="https://i.morioh.com/67feeaf72f.png",
            Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course {
            CourseId = 11, Title = "Data Analysis using Python", Description = "analyze data using Python",
            Fee = 1200, isWeekendClassAvailable = true, ImageUrl ="https://cognitiveclass.ai/wp-content/uploads/2016/11/Data-Analysis-with-Python.png",
            Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course {
            CourseId = 13, Title = "Data Analysis using R", Description = "analyze data using R",
            Fee = 1300, isWeekendClassAvailable = true, ImageUrl ="https://blog.efpsa.org/wp-content/uploads/2016/11/Rlogo-e1480880036146.png",
            Category = categoryRepository.AllCategories.ToList()[1]
            },
            new Course {
            CourseId = 21, Title = "Android Application Development", Description = "Java and XML are the two main programming languages used in Android App development. Knowledge and mastery over these programming languages are, therefore, prerequisites to developing an Android app.",
            Fee = 1550, isWeekendClassAvailable = true, ImageUrl ="https://img.favpng.com/16/25/22/mobile-app-development-android-software-development-png-favpng-cDsQxvcqcgg5UPJkKtrknAEXG.jpg",
            Category = categoryRepository.AllCategories.ToList()[2]
            },
            new Course {
            CourseId = 22, Title = "IO Application Development", Description = "Applications that run on any browser, fast, secure and scalable.",
            Fee = 1750, isWeekendClassAvailable = true, ImageUrl ="https://hackr.io/blog/rapid-application-development-model/thumbnail/large",
            Category = categoryRepository.AllCategories.ToList()[2]
            },
        };

        public IEnumerable<Course> FreeCourseOfTheWeek { get; }

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(c => c.CourseId == courseId);
        }

    }
}
