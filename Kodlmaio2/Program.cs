// See https://aka.ms/new-console-template for more information
using Kodlmaio2.Bussiness.Concrete;
using Kodlmaio2.DataAccess.Concrete;
using Kodlmaio2.Entities.Concrete;
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("-------Tüm Kursları Listelenmesi--------");
Console.WriteLine("--------------------------------------------------");
CourseManager courseManager = new(new CourseDal());

List<Course> courses = courseManager.GetAll();
Console.WriteLine(courses);
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
}


courseManager.Add(new Course()
{
    Id = 5,
    CategoryId = 1,
    InstructorId = 1,
    Name = "Kotlin İle Mobil Uygulama",
    Description = "New.. Course",
    Percentage = 0
});
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("-------Yeni Kurs Eklendi ve Tüm Kursları Listeleme --------");
Console.WriteLine("--------------------------------------------------");

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
}

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("------- Course Updated and Get All Courses--------");
Console.WriteLine("--------------------------------------------------");
courseManager.Update(new Course()
{
    Id = 5,
    CategoryId = 1,
    InstructorId = 1,
    Name = "Net ve Anguler İle Web Tasarım",
    Description = "Updated",
    Percentage = 0
});
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
}
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("------- Get Id By Course--------");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine(courseManager.Get(5).Name); 
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("------- Delete Course--------");
Console.WriteLine("--------------------------------------------------");
courseManager.Delete(5);
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
}
