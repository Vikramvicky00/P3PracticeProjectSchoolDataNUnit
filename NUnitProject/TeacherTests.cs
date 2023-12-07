using SchoolData;

namespace NUnitProject
{
    [TestFixture]
    internal class TeacherTests
    {
        [Test]
        public void TestTeacherName()
        {
            
            Teacher myTeacher = new Teacher();
            myTeacher.Name = "Vicky";
            
            string teacherName = myTeacher.Name;
            
            Assert.AreEqual("Vicky", teacherName);
        }
        [Test]
        public void TestClassId()
        {
            
            Teacher myTeacher = new Teacher();
            myTeacher.Id = 1;
    
            int tecaherId = myTeacher.Id;
            
            Assert.AreEqual(1, tecaherId);
        }

    }
}
