using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        UniversityDBContext db = new UniversityDBContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dep_grid.DataSource = db.Departments.ToList();
            Prof_Grid.DataSource = db.Professors.ToList();
            Course_grid.DataSource = db.Courses.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    
            
        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_prof ()
        {
            Prof_name.Text = string.Empty;
            Prof_phone.Text = string.Empty;
            Prof_ID.Text=string.Empty;
            Prof_age.Text = string.Empty;
            Prof_exp.Text = string.Empty;
            Dep_ID.Text = string.Empty;
        }

        private void Clear_Course ()
        {
            Course_name.Text = string.Empty;
            Course_ID.Text = string.Empty;
            Course_lvl.Text = string.Empty;
            course_profid.Text = string.Empty;
        }

        private void Clear_Dep()
        {
            Dep_name.Text = string.Empty;
            depID.Text = string.Empty;
            Description.Text = string.Empty;
        }

        private void Add_prof1(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(Prof_name.Text) || string.IsNullOrWhiteSpace(Prof_age.Text) ||
                string.IsNullOrWhiteSpace(Prof_phone.Text) || string.IsNullOrWhiteSpace(Prof_exp.Text) ||
                string.IsNullOrWhiteSpace(Prof_ID.Text) || string.IsNullOrWhiteSpace(Dep_ID.Text))
            {
                MessageBox.Show("Please fill in all fields before adding the professor.");
                return; // Exit the method if any field is empty
            }

            // Check if age is a valid integer
            if (!int.TryParse(Prof_age.Text, out int professorAge))
            {
                MessageBox.Show("Please enter a valid integer for Age.");
                return; // Exit the method if Age is not a valid integer
            }

            // Check if YearsOfExperience is a valid integer
            if (!int.TryParse(Prof_exp.Text, out int professorExperience))
            {
                MessageBox.Show("Please enter a valid integer for Years of Experience.");
                return; // Exit the method if Years of Experience is not a valid integer
            }

            // Check if ProfessorID is a valid integer
            if (!int.TryParse(Prof_ID.Text, out int professorID))
            {
                MessageBox.Show("Please enter a valid integer for Professor ID.");
                return; // Exit the method if Professor ID is not a valid integer
            }

            // Check if DepartmentID is a valid integer
            if (!int.TryParse(Dep_ID.Text, out int DepartmentID))
            {
                MessageBox.Show("Please enter a valid integer for Department ID.");
                return; // Exit the method if Department ID is not a valid integer
            }

            // Check if the referenced DepartmentId exists in the department table
            var existingDepartment = db.Departments.Find(DepartmentID);
            if (existingDepartment == null)
            {
                MessageBox.Show("Department with the specified ID does not exist.");
                return; // Exit the method if the referenced DepartmentId doesn't exist
            }

            // All checks passed, proceed to create and add the professor
            string professorName = Prof_name.Text;
            string professorPhone = Prof_phone.Text;

            Professor newProfessor = new Professor
            {
                Name = professorName,
                Age = professorAge,
                Phone = professorPhone,
                YearsOfExperience = professorExperience,
                Id = professorID,
                DepartmentId = DepartmentID
            };

            ProfessorRepository professorRepository = new ProfessorRepository(db);
            professorRepository.AddProfessor(newProfessor);
            Prof_Grid.DataSource = db.Professors.ToList();
            Clear_prof ();

        }

        private void Add_Dep1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Dep_name.Text) || string.IsNullOrWhiteSpace(depID.Text) || string.IsNullOrWhiteSpace(Description.Text))
            {
                MessageBox.Show("Please fill in all fields before adding the department.");
                return; // Exit the method if any field is empty
            }

            // Check if DepartmentID is a valid integer
            if (!int.TryParse(depID.Text, out int DepartmentID))
            {
                MessageBox.Show("Please enter a valid integer for Department ID.");
                return; // Exit the method if DepartmentID is not a valid integer
            }

            // All checks passed, proceed to create and add the department
            string DepartmentName = Dep_name.Text;
            string dep_Description = Description.Text;
            

            Department newDepartment = new Department
            {
                Name = DepartmentName,
                Id = DepartmentID,
                Description = dep_Description
            };

            DepartmentRepository departmentRepository = new DepartmentRepository(db);
            departmentRepository.AddDepartment(newDepartment);
            Dep_grid.DataSource = db.Departments.ToList();
            Clear_Dep();


        }


        private void Prof_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Dep1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(depID.Text))
            {
                MessageBox.Show("Please enter a department ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if DepartmentID is a valid integer
            if (!int.TryParse(depID.Text, out int departmentId))
            {
                MessageBox.Show("Please enter a valid integer for Department ID.");
                return; // Exit the method if Department ID is not a valid integer
            }

            // Use the DepartmentRepository to check if the department ID exists
            DepartmentRepository departmentRepository = new DepartmentRepository(db);
            var existingDepartment = departmentRepository.GetDepartmentById(departmentId);

            if (existingDepartment != null)
            {
                // Department exists, proceed to delete
                departmentRepository.DeleteDepartment(departmentId);
                Dep_grid.DataSource = db.Departments.ToList();
                Clear_Dep();
            }
            else
            {
                // Department ID does not exist in the table
                MessageBox.Show("Department with the specified ID does not exist.");
            }
        }

        private void Delete_prof1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Prof_ID.Text))
            {
                MessageBox.Show("Please enter a professor ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if ProfessorID is a valid integer
            if (!int.TryParse(Prof_ID.Text, out int professorId))
            {
                MessageBox.Show("Please enter a valid integer for Professor ID.");
                return; // Exit the method if Professor ID is not a valid integer
            }

            // Use the ProfessorRepository to check if the professor ID exists
            ProfessorRepository professorRepository = new ProfessorRepository(db);
            var existingProfessor = professorRepository.GetProfessorById(professorId);

            if (existingProfessor != null)
            {
                // Professor exists, proceed to delete
                professorRepository.DeleteProfessor(professorId);
                Prof_Grid.DataSource = db.Professors.ToList();
                Clear_prof ();

            }
            else
            {
                // Professor ID does not exist in the table
                MessageBox.Show("Professor with the specified ID does not exist.");
            }
        }

        private void Add_course(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(Course_name.Text) || string.IsNullOrWhiteSpace(Course_ID.Text)
                || string.IsNullOrWhiteSpace(Course_lvl.Text) || string.IsNullOrWhiteSpace(course_profid.Text))
            {
                MessageBox.Show("Please fill in all fields before adding the course.");
                return; // Exit the method if any field is empty
            }

            // Check if ID is a valid integer
            if (!int.TryParse(Course_ID.Text, out int courseId))
            {
                MessageBox.Show("Please enter a valid integer for Course ID.");
                return; // Exit the method if Course ID is not a valid integer
            }

            // Check if professorId is a valid integer
            if (!int.TryParse(course_profid.Text, out int professorId))
            {
                MessageBox.Show("Please enter a valid integer for Professor ID.");
                return; // Exit the method if Professor ID is not a valid integer
            }

            // Use the ProfessorRepository to check if the professorId exists
            ProfessorRepository professorRepository = new ProfessorRepository(db);
            var existingProfessor = professorRepository.GetProfessorById(professorId);

            if (existingProfessor != null)
            {
                // Professor exists, proceed to create and add the course
                Course newCourse = new Course
                {
                    Name = Course_name.Text,
                    Id = courseId,
                    Level = Course_lvl.Text,
                    ProfessorId = professorId
                };

                // Use the CourseRepository to add the new course
                CourseRepository courseRepository = new CourseRepository(db);
                courseRepository.AddCourse(newCourse);
                Course_grid.DataSource = db.Courses.ToList();
                Clear_Course ();
            }
            else
            {
                // Professor ID does not exist in the professor table
                MessageBox.Show("Professor with the specified ID does not exist.");
            }
        }

        private void Delete_course1(object sender, EventArgs e)
        {
            if (int.TryParse(Course_ID.Text, out int courseIdToDelete))
            {
                // Check if the course ID exists
                CourseRepository courseRepository = new CourseRepository(db);
                var existingCourse = courseRepository.GetCourseById(courseIdToDelete);

                if (existingCourse != null)
                {
                    // Use the CourseRepository to delete the course
                    courseRepository.DeleteCourse(courseIdToDelete);
                    Course_grid.DataSource = db.Courses.ToList();
                    Clear_Course ();

                }
                else
                {
                    // Handle the case where the course ID does not exist
                    MessageBox.Show("Course ID does not exist.");
                }
            }
            else
            {
                // Handle the case where the user entered an invalid ID
                MessageBox.Show("Please enter a valid course ID.");
            }
        }

        private void Update_dep1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(depID.Text))
            {
                MessageBox.Show("Please enter a department ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if DepartmentID is a valid integer
            if (!int.TryParse(depID.Text, out int departmentId))
            {
                MessageBox.Show("Please enter a valid integer for Department ID.");
                return; // Exit the method if Department ID is not a valid integer
            }

            // Use the DepartmentRepository to check if the department ID exists
            DepartmentRepository departmentRepository = new DepartmentRepository(db);
            var existingDepartment = departmentRepository.GetDepartmentById(departmentId);

            if (existingDepartment != null)
            {
                // Department exists, proceed to update values
                string newName = Dep_name.Text;
                string newDescription = Description.Text;

                Department updatedDepartment = new Department
                {
                    Id = departmentId,
                    Name = newName,
                    Description = newDescription
                };

                // Use the DepartmentRepository to update the department
                departmentRepository.UpdateDepartment(updatedDepartment);
                Dep_grid.DataSource = db.Departments.ToList();
                Clear_Dep();
            }
            else
            {
                // Department ID does not exist in the table
                MessageBox.Show("Department with the specified ID does not exist.");
            }

        }

        private void Update_prof1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(Prof_ID.Text))
            {
                MessageBox.Show("Please enter a professor ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if ProfessorID is a valid integer
            if (!int.TryParse(Prof_ID.Text, out int professorId))
            {
                MessageBox.Show("Please enter a valid integer for Professor ID.");
                return; // Exit the method if Professor ID is not a valid integer
            }

            // Use the ProfessorRepository to check if the professor ID exists
            ProfessorRepository professorRepository = new ProfessorRepository(db);
            var existingProfessor = professorRepository.GetProfessorById(professorId);

            if (existingProfessor != null)
            {
                // Professor exists, proceed to update values
                string newName = Prof_name.Text;
                string newAgeString = Prof_age.Text;
                string newPhone = Prof_phone.Text;
                string newExperienceString = Prof_exp.Text;
                string newDepartmentIdString = Dep_ID.Text;

                // Check if Age is a valid integer
                if (!int.TryParse(newAgeString, out int newAge))
                {
                    MessageBox.Show("Please enter a valid integer for Age.");
                    return; // Exit the method if Age is not a valid integer
                }

                // Check if YearsOfExperience is a valid integer
                if (!int.TryParse(newExperienceString, out int newExperience))
                {
                    MessageBox.Show("Please enter a valid integer for Years of Experience.");
                    return; // Exit the method if Years of Experience is not a valid integer
                }

                // Check if DepartmentId is a valid integer
                if (!int.TryParse(newDepartmentIdString, out int newDepartmentId))
                {
                    MessageBox.Show("Please enter a valid integer for Department ID.");
                    return; // Exit the method if Department ID is not a valid integer
                }

                // Use the DepartmentRepository to check if the new DepartmentId exists
                var existingDepartment = db.Departments.Find(newDepartmentId);
                if (existingDepartment == null)
                {
                    MessageBox.Show("Department with the specified ID does not exist.");
                    return; // Exit the method if the new DepartmentId doesn't exist
                }

                // All checks passed, proceed to update values
                existingProfessor.Name = newName;
                existingProfessor.Age = newAge;
                existingProfessor.Phone = newPhone;
                existingProfessor.YearsOfExperience = newExperience;
                existingProfessor.DepartmentId = newDepartmentId;

                // Use the ProfessorRepository to update the professor
                professorRepository.UpdateProfessor(existingProfessor);
                Prof_Grid.DataSource = db.Professors.ToList();
                Clear_prof ();
            }
            else
            {
                // Professor ID does not exist in the table
                MessageBox.Show("Professor with the specified ID does not exist.");
            }

        }

        private void Update_Course1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(Course_ID.Text))
            {
                MessageBox.Show("Please enter a course ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if CourseID is a valid integer
            if (!int.TryParse(Course_ID.Text, out int courseId))
            {
                MessageBox.Show("Please enter a valid integer for Course ID.");
                return; // Exit the method if Course ID is not a valid integer
            }

            // Use the CourseRepository to check if the course ID exists
            CourseRepository courseRepository = new CourseRepository(db);
            var existingCourse = courseRepository.GetCourseById(courseId);

            if (existingCourse != null)
            {
                // Course exists, proceed to update values
                string newName = Course_name.Text;
                string newLevel = Course_lvl.Text;
                string newProfessorIdString = course_profid.Text;

                // Check if ProfessorId is a valid integer
                if (!int.TryParse(newProfessorIdString, out int newProfessorId))
                {
                    MessageBox.Show("Please enter a valid integer for Professor ID.");
                    return; // Exit the method if Professor ID is not a valid integer
                }

                // Use the ProfessorRepository to check if the new ProfessorId exists
                ProfessorRepository professorRepository = new ProfessorRepository(db);
                var existingProfessor = professorRepository.GetProfessorById(newProfessorId);
                if (existingProfessor == null)
                {
                    MessageBox.Show("Professor with the specified ID does not exist.");
                    return; // Exit the method if the new ProfessorId doesn't exist
                }

                // All checks passed, proceed to update values
                existingCourse.Name = newName;
                existingCourse.Level = newLevel;
                existingCourse.ProfessorId = newProfessorId;

                // Use the CourseRepository to update the course
                courseRepository.UpdateCourse(existingCourse);
                Course_grid.DataSource = db.Courses.ToList();
                Clear_Course ();
            }
            else
            {
                // Course ID does not exist in the table
                MessageBox.Show("Course with the specified ID does not exist.");
            }

        }

        private void Retrieve_prof1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(Prof_ID.Text))
            {
                MessageBox.Show("Please enter a professor ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if ProfessorID is a valid integer
            if (!int.TryParse(Prof_ID.Text, out int professorId))
            {
                MessageBox.Show("Please enter a valid integer for Professor ID.");
                return; // Exit the method if Professor ID is not a valid integer
            }

            // Use the ProfessorRepository to get the professor by ID
            ProfessorRepository professorRepository = new ProfessorRepository(db);
            var professor = professorRepository.GetProfessorById(professorId);

            if (professor != null)
            {
                // Professor with the specified ID exists, show the information in a MessageBox
                string professorInfo = $"Professor ID: {professor.Id}\n" +
                                       $"Name: {professor.Name}\n" +
                                       $"Age: {professor.Age}\n" +
                                       $"Phone: {professor.Phone}\n" +
                                       $"Years of Experience: {professor.YearsOfExperience}\n" +
                                       $"Department ID: {professor.DepartmentId}";

                MessageBox.Show(professorInfo, "Professor Information");
                Clear_prof ();
            }
            else
            {
                // Professor with the specified ID does not exist
                MessageBox.Show("Professor with the specified ID does not exist.");
            }
        }

        private void Retrieve_Dep1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(depID.Text))
            {
                MessageBox.Show("Please enter a department ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if DepartmentID is a valid integer
            if (!int.TryParse(depID.Text, out int departmentId))
            {
                MessageBox.Show("Please enter a valid integer for Department ID.");
                return; // Exit the method if Department ID is not a valid integer
            }

            // Use the DepartmentRepository to get the department by ID
            DepartmentRepository departmentRepository = new DepartmentRepository(db);
            var department = departmentRepository.GetDepartmentById(departmentId);

            if (department != null)
            {
                // Department with the specified ID exists, show the information in a MessageBox
                string departmentInfo = $"Department ID: {department.Id}\n" +
                                        $"Name: {department.Name}\n" +
                                        $"Description: {department.Description}";

                MessageBox.Show(departmentInfo, "Department Information");
                Clear_Dep();
            }
            else
            {
                // Department with the specified ID does not exist
                MessageBox.Show("Department with the specified ID does not exist.");
            }
        }

        private void Retrieve_course1(object sender, EventArgs e)
        {
            // Check if the ID field is empty
            if (string.IsNullOrWhiteSpace(Course_ID.Text))
            {
                MessageBox.Show("Please enter a course ID.");
                return; // Exit the method if the ID field is empty
            }

            // Check if CourseID is a valid integer
            if (!int.TryParse(Course_ID.Text, out int courseId))
            {
                MessageBox.Show("Please enter a valid integer for Course ID.");
                return; // Exit the method if Course ID is not a valid integer
            }

            // Use the CourseRepository to get the course by ID
            CourseRepository courseRepository = new CourseRepository(db);
            var course = courseRepository.GetCourseById(courseId);

            if (course != null)
            {
                // Course with the specified ID exists, show the information in a MessageBox
                string courseInfo = $"Course ID: {course.Id}\n" +
                                    $"Name: {course.Name}\n" +
                                    $"Level: {course.Level}\n" +
                                    $"Professor ID: {course.ProfessorId}";

                MessageBox.Show(courseInfo, "Course Information");
                Clear_Course ();
            }
            else
            {
                // Course with the specified ID does not exist
                MessageBox.Show("Course with the specified ID does not exist.");
            }
        }
    }
    
}
