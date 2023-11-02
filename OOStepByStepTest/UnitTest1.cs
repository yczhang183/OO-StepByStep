namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_message_include_name_age_when_introduce_given_person()
        {
            //Given
            Person person = new Person("Tom", 21);

            //When
            string result = person.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }

    public class StudentTest
    {
        [Fact]
        public void Should_return_message_include_name_age_student_when_introduce_given_student()
        {
            //Given
            Student student = new Student("Tom", 21);

            //When
            string result = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", result);
        }
    }

    public class TeacherTest
    {
        [Fact]
        public void Should_return_message_include_name_age_teacher_when_introduce_given_teacher()
        {
            //Given
            Teacher teacher = new Teacher("Amy", 30);

            //When
            string result = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }
    }

    public class ClassTest
    {
        [Fact]
        public void Should_return_message_include_name_age_student_class_when_introduce_given_student()
        {
            //Given
            Class class2 = new Class("2");
            Student student = new Student("Tom", 21);
            class2.Add(student);

            //When
            string result = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 2.", result);
        }

        [Fact]
        public void Should_return_message_include_name_age_teacher_class_when_introduce_given_teacher()
        {
            //Given
            Class class2 = new Class("2");
            Teacher teacher = new Teacher("Tom", 21);
            class2.Add(teacher);

            //When
            string result = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }
    }
}
