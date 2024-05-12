using JD.com.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JD.com.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<College> College { get; set; }
        public DbSet<CourseGroup> CourseGroup { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<CollegeCourse> CollegeCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //\\\\\\---------------------
            modelBuilder.Entity<CollegeCourse>()
         .HasKey(cc => new { cc.CollegeId, cc.CourseId });

            modelBuilder.Entity<CollegeCourse>()
                .HasOne(cc => cc.College)
                .WithMany()
                .HasForeignKey(cc => cc.CollegeId);

            modelBuilder.Entity<CollegeCourse>()
                .HasOne(cc => cc.Course)
                .WithMany()
                .HasForeignKey(cc => cc.CourseId);

            //\\\-------------------------

            // Seed data here
            modelBuilder.Entity<State>().HasData(
                new State { StateId = 1, StateName = "J&K" },   //---------done
                new State { StateId = 2, StateName = "Delhi" },
                new State { StateId = 4, StateName = "Uttarakhand" }, //------------done
                new State { StateId = 5, StateName = "Punjab" }, //---------------done
                new State { StateId = 6, StateName = "Banglore" } //-------done
                );
            modelBuilder.Entity<College>().HasData(
                new College { CollegeId = 1, CollegeName = "BFIT", StateId = 4 },
                new College { CollegeId = 2, CollegeName = "Baba Farid College", StateId = 5 },
                new College { CollegeId = 3, CollegeName = "Degree College Baramulla", StateId = 1 },
                new College { CollegeId = 5, CollegeName = "Dev Bhoomi", StateId = 4 },
                new College { CollegeId = 6, CollegeName = "Dhoon International", StateId = 4 },
                new College { CollegeId = 7, CollegeName = "Dolphin College", StateId = 4 },
                new College { CollegeId = 8, CollegeName = "Guru Nanak College", StateId = 4 },
                new College { CollegeId = 9, CollegeName = "LPU", StateId = 5 },
                new College { CollegeId = 10, CollegeName = "Chandigarh College of Hotel Management ", StateId = 5 },
                new College { CollegeId = 11, CollegeName = "Chandigarh Group of Colleges ", StateId = 5 },
                new College { CollegeId = 12, CollegeName = "Chandigarh Group of Colleges ", StateId = 5 },
                new College { CollegeId = 13, CollegeName = "Degree College Pattan", StateId = 1 },
                new College { CollegeId = 14, CollegeName = "Degree College Singpora", StateId = 1 },
                new College { CollegeId = 15, CollegeName = "Amar Singh College", StateId = 1 },
                new College { CollegeId = 16, CollegeName = "NIT", StateId = 1 },
                new College { CollegeId = 17, CollegeName = "IUST", StateId = 1 },
                new College { CollegeId = 18, CollegeName = "Degree College Bemina", StateId = 1 },
                new College { CollegeId = 19, CollegeName = "Banglore College Of technology", StateId = 6 },
                new College { CollegeId = 20, CollegeName = "Christ University", StateId = 6 },
                new College { CollegeId = 21, CollegeName = "Bangalore University", StateId = 6 },
                new College { CollegeId = 22, CollegeName = "Mount Carmel College Autonomous", StateId = 6 },
                new College { CollegeId = 23, CollegeName = "Indian Institute Of Management–Bangalore", StateId = 6 },
                new College { CollegeId = 24, CollegeName = "R. V. College of Engineering", StateId = 6 },
                new College { CollegeId = 25, CollegeName = "Delhi University", StateId = 2 },
                new College { CollegeId = 26, CollegeName = "Jamia Millia Islamia", StateId = 2 },
                new College { CollegeId = 27, CollegeName = "Indian Institute Of Technology Delhi", StateId = 2 },
                new College { CollegeId = 28, CollegeName = "All India Institute Of Medical Sciences Delhi", StateId = 2 },
                new College { CollegeId = 29, CollegeName = "Delhi Technological University", StateId = 2 },
                new College { CollegeId = 30, CollegeName = "Jamia Hamdard University", StateId = 2 });

            modelBuilder.Entity<CourseGroup>().HasData(
                new CourseGroup() { CourseGroupId = 1, CourseGroupName = "Information Technology" },
                new CourseGroup() { CourseGroupId = 2, CourseGroupName = "Engineering" },
                new CourseGroup() { CourseGroupId = 3, CourseGroupName = "Science" },
                new CourseGroup() { CourseGroupId = 4, CourseGroupName = "Hotel Management" }
                );
            modelBuilder.Entity<Exams>().HasData(
                new Exams() { ExamId = 1, ExamName = "NIMCET", CourseGroupId = 1 },
                new Exams() { ExamId = 2, ExamName = "C-CAT", CourseGroupId = 1 },
                new Exams() { ExamId = 3, ExamName = "UGAT", CourseGroupId = 1 },
                new Exams() { ExamId = 4, ExamName = "BITSAT", CourseGroupId = 1 },
                new Exams() { ExamId = 5, ExamName = "GATE", CourseGroupId = 1 },
                new Exams() { ExamId = 6, ExamName = "BITSAT", CourseGroupId = 2 },
                new Exams() { ExamId = 7, ExamName = "VITEE", CourseGroupId = 2 },
                new Exams() { ExamId = 8, ExamName = "JEE MAIN", CourseGroupId = 2 },
                new Exams() { ExamId = 9, ExamName = "JEE ADVANCED", CourseGroupId = 2 },
                new Exams() { ExamId = 10, ExamName = "MHT CET", CourseGroupId = 2 },
                new Exams() { ExamId = 11, ExamName = "SRM JEEE", CourseGroupId = 2 },
                new Exams() { ExamId = 12, ExamName = "CUET", CourseGroupId = 3 },
                new Exams() { ExamId = 13, ExamName = "NEET", CourseGroupId = 3 },
                new Exams() { ExamId = 14, ExamName = "NATA", CourseGroupId = 3 },
                new Exams() { ExamId = 15, ExamName = "SAT", CourseGroupId = 3 },
                new Exams() { ExamId = 16, ExamName = "AILET", CourseGroupId = 3 },
                new Exams() { ExamId = 17, ExamName = "AP EAMCET", CourseGroupId = 3 },
                new Exams() { ExamId = 18, ExamName = "CLAT", CourseGroupId = 3 },
                new Exams() { ExamId = 19, ExamName = "NEST", CourseGroupId = 3 },
                new Exams() { ExamId = 20, ExamName = "UGAT", CourseGroupId = 4 },
                new Exams() { ExamId = 21, ExamName = "CUET", CourseGroupId = 4 },
                new Exams() { ExamId = 22, ExamName = "PUTHAT", CourseGroupId = 4 },
                new Exams() { ExamId = 23, ExamName = "NCHMCT", CourseGroupId = 4 },
                new Exams() { ExamId = 24, ExamName = "oberoi STEP", CourseGroupId = 4 },
                new Exams() { ExamId = 25, ExamName = "BVPCET", CourseGroupId = 4 },
                new Exams() { ExamId = 26, ExamName = "IPU", CourseGroupId = 4 },
                new Exams() { ExamId = 27, ExamName = "MAH HM CET", CourseGroupId = 4 }
                );

            modelBuilder.Entity<Courses>().HasData(
                new Courses() { CourseId = 1, CourseName = "BCA", CourseGroupId = 1 },
                new Courses() { CourseId = 2, CourseName = "BscIT", CourseGroupId = 1 },
                new Courses() { CourseId = 3, CourseName = "MCA", CourseGroupId = 1 },
                new Courses() { CourseId = 4, CourseName = "MSC IT", CourseGroupId = 1 },
                new Courses() { CourseId = 5, CourseName = "BTEC COMPUTER", CourseGroupId = 1 },
                new Courses() { CourseId = 6, CourseName = "BTECH CIVIL", CourseGroupId = 2 },
                new Courses() { CourseId = 7, CourseName = "BTECH MECHINICAL", CourseGroupId = 2 },
                new Courses() { CourseId = 8, CourseName = "BTECH ELECTRICAL", CourseGroupId = 2 },
                new Courses() { CourseId = 9, CourseName = "MTECH CIVIL", CourseGroupId = 2 },
                new Courses() { CourseId = 10, CourseName = "MTECH MECHINICAL", CourseGroupId = 2 },
                new Courses() { CourseId = 11, CourseName = "MTECH ELECTRICAL", CourseGroupId = 2 },
                new Courses() { CourseId = 12, CourseName = "BSC BIOLOGY", CourseGroupId = 3 },
                new Courses() { CourseId = 13, CourseName = "MSC BIOLOGY", CourseGroupId = 3 },
                new Courses() { CourseId = 14, CourseName = "BSC Chemistry", CourseGroupId = 3 },
                new Courses() { CourseId = 15, CourseName = "MSC Chemistry", CourseGroupId = 3 },
                new Courses() { CourseId = 16, CourseName = "MSC Physics", CourseGroupId = 3 },
                new Courses() { CourseId = 17, CourseName = "BSC Physics", CourseGroupId = 3 },
                new Courses() { CourseId = 18, CourseName = "Bachelor Of Hotel Management.", CourseGroupId = 4 },
                new Courses() { CourseId = 19, CourseName = "Masters Of Hotel Management.", CourseGroupId = 4 },
                new Courses() { CourseId = 20, CourseName = "Diploma Of Hotel Management.", CourseGroupId = 4 },
                new Courses() { CourseId = 21, CourseName = "BSc in Hospitality And Hotel Administration.", CourseGroupId = 4 },
                new Courses() { CourseId = 22, CourseName = "Diploma in Food and Beverage services.", CourseGroupId = 4 },
                new Courses() { CourseId = 23, CourseName = "Advanced Diploma in Hospitality Management.", CourseGroupId = 4 }
                );
        }
          
    }
    
}
