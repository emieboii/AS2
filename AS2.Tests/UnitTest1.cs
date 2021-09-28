using System;
using static AS2.Status;
using static AS2.StatusController;
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

        [Fact]
        public void StatusController_Status_returns_New_when_totalDays_lower_than_0()
        {
            var controller = new StatusController();

            DateTime started = new DateTime(2021, 9, 29, 0, 0 ,0);
            DateTime today   = new DateTime(2021, 9, 28, 0, 0 ,0);

            var exp = Status.New;
            var result = controller.status(started, today);

            Assert.Equal(exp, result);
        }

        [Fact]
        public void StatusController_Status_returns_Active_when_totalTime_less_than_3_years()
        {
            var controller = new StatusController();

            DateTime started = new DateTime(2021, 9, 29, 0, 0 ,0);
            DateTime today   = new DateTime(2021, 10, 28, 0, 0 ,0);

            var exp = Status.Active;
            var result = controller.status(started, today);

            Assert.Equal(exp, result);
        }

        [Fact]
        public void StatusController_Status_returns_Graduated_when_totalTime_above_3_years()
        {
            var controller = new StatusController();

            DateTime started = new DateTime(2021, 9, 29, 0, 0 ,0);
            DateTime today   = new DateTime(2025, 10, 28, 0, 0 ,0);

            var exp = Status.Graduated;
            var result = controller.status(started, today);

            Assert.Equal(exp, result);
        }
    }
}
