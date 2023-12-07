using SchoolData;

namespace NUnitProject
{
    internal class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            
            Student student = new Student();
            student.Name = "Vikram";
            
            string studentName = student.Name;
            
            Assert.AreEqual("Vikram", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            
            Student student = new Student();
            student.Address = "Maddilapalem";
            
            string studentAddress = student.Address;
            
            Assert.AreEqual("Maddilapalem", studentAddress);
        }

    }
}
