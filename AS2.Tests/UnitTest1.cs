using System;
using Xunit;

namespace AS2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Student_id_set_to_1_returns_id_of_1()
        {
            var student = new Student();
            student.Id = 1;

            var expected = 1;
            Assert.Equal(expected, student.Id);
        }

        [Fact]
        public void Student_id_set_arbitrarily_lower_than_0_returns_negative_1()
        {
            var student = new Student();
            student.Id = -5;

            var expected = -1;
            Assert.Equal(expected, student.Id);
        }
    }
}
