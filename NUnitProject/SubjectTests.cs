using SchoolData;

namespace NUnitProject
{
    internal class SubjectTests
    {
        [Test]
        public void TestSubjectName()
        {
            Subject subject = new Subject();
            subject.Name = "Maths";
            string subjectName = subject.Name;
            Assert.AreEqual("Maths", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            
            Subject subject = new Subject();
            subject.Id = 5;
            int subjectId = subject.Id;
             Assert.AreEqual(5, subjectId);
        }
    }
}
