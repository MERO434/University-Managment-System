using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_Managment_System.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicGrades_Courses_CourseId",
                table: "AcademicGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicGrades_Students_StudentId",
                table: "AcademicGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecords_Courses_CourseId",
                table: "AcademicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecords_Semesters_SemesterId",
                table: "AcademicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecords_Students_StudentId",
                table: "AcademicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorCourses_Administrators_AdministratorsId",
                table: "AdministratorCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorCourses_Courses_ManagedCoursesId",
                table: "AdministratorCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_Roles_RoleId",
                table: "Administrators");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Courses_CourseId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Books_BookId",
                table: "BookLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Students_StudentId",
                table: "BookLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_Courseprof_Courses_CoursesId",
                table: "Courseprof");

            migrationBuilder.DropForeignKey(
                name: "FK_Courseprof_Professors_ProfessorsId",
                table: "Courseprof");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeachingAssistant_Courses_CoursesId",
                table: "CourseTeachingAssistant");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeachingAssistant_TeachingAssistants_TeachingAssistantsTeachingAssistantId",
                table: "CourseTeachingAssistant");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrollStudentInCourse_Courses_CourseId",
                table: "EnrollStudentInCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrollStudentInCourse_Semesters_SemesterId",
                table: "EnrollStudentInCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrollStudentInCourse_Students_StudentId",
                table: "EnrollStudentInCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Roles_RoleId",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_FinalGrades_Courses_CourseId",
                table: "FinalGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_FinalGrades_Students_StudentId",
                table: "FinalGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_Finances_Semesters_SemesterId",
                table: "Finances");

            migrationBuilder.DropForeignKey(
                name: "FK_Finances_Students_StudentId",
                table: "Finances");

            migrationBuilder.DropForeignKey(
                name: "FK_Grievances_Users_UserId",
                table: "Grievances");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassrooms_Semesters_SemesterId",
                table: "LectureClassrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_Courses_CourseId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_LectureClassrooms_LectureClassroomId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_Professors_ProfessorId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_Semesters_SemesterId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Departments_DepartmentId",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Roles_RoleId",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistrationGenerators_Students_StudentId",
                table: "RegistrationGenerators");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_Courses_CourseId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_SectionRooms_RoomId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_Semesters_SemesterId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_TeachingAssistants_TeachingAssistantId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionRooms_Semesters_SemesterId",
                table: "SectionRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Roles_RoleId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingAssistants_Departments_DepartmentId",
                table: "TeachingAssistants");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingAssistants_Roles_RoleId",
                table: "TeachingAssistants");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicGrades_Courses_CourseId",
                table: "AcademicGrades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicGrades_Students_StudentId",
                table: "AcademicGrades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecords_Courses_CourseId",
                table: "AcademicRecords",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecords_Semesters_SemesterId",
                table: "AcademicRecords",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecords_Students_StudentId",
                table: "AcademicRecords",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorCourses_Administrators_AdministratorsId",
                table: "AdministratorCourses",
                column: "AdministratorsId",
                principalTable: "Administrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorCourses_Courses_ManagedCoursesId",
                table: "AdministratorCourses",
                column: "ManagedCoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_Roles_RoleId",
                table: "Administrators",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Courses_CourseId",
                table: "Attendances",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Books_BookId",
                table: "BookLoans",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Students_StudentId",
                table: "BookLoans",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Courseprof_Courses_CoursesId",
                table: "Courseprof",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Courseprof_Professors_ProfessorsId",
                table: "Courseprof",
                column: "ProfessorsId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeachingAssistant_Courses_CoursesId",
                table: "CourseTeachingAssistant",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeachingAssistant_TeachingAssistants_TeachingAssistantsTeachingAssistantId",
                table: "CourseTeachingAssistant",
                column: "TeachingAssistantsTeachingAssistantId",
                principalTable: "TeachingAssistants",
                principalColumn: "TeachingAssistantId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollStudentInCourse_Courses_CourseId",
                table: "EnrollStudentInCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollStudentInCourse_Semesters_SemesterId",
                table: "EnrollStudentInCourse",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollStudentInCourse_Students_StudentId",
                table: "EnrollStudentInCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Roles_RoleId",
                table: "Faculties",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FinalGrades_Courses_CourseId",
                table: "FinalGrades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FinalGrades_Students_StudentId",
                table: "FinalGrades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Finances_Semesters_SemesterId",
                table: "Finances",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Finances_Students_StudentId",
                table: "Finances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Grievances_Users_UserId",
                table: "Grievances",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassrooms_Semesters_SemesterId",
                table: "LectureClassrooms",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_Courses_CourseId",
                table: "LectureClassSchedules",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_LectureClassrooms_LectureClassroomId",
                table: "LectureClassSchedules",
                column: "LectureClassroomId",
                principalTable: "LectureClassrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_Professors_ProfessorId",
                table: "LectureClassSchedules",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_Semesters_SemesterId",
                table: "LectureClassSchedules",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Departments_DepartmentId",
                table: "Professors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Roles_RoleId",
                table: "Professors",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrationGenerators_Students_StudentId",
                table: "RegistrationGenerators",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_Courses_CourseId",
                table: "SectionClassSchedules",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_SectionRooms_RoomId",
                table: "SectionClassSchedules",
                column: "RoomId",
                principalTable: "SectionRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_Semesters_SemesterId",
                table: "SectionClassSchedules",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_TeachingAssistants_TeachingAssistantId",
                table: "SectionClassSchedules",
                column: "TeachingAssistantId",
                principalTable: "TeachingAssistants",
                principalColumn: "TeachingAssistantId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionRooms_Semesters_SemesterId",
                table: "SectionRooms",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Roles_RoleId",
                table: "Students",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingAssistants_Departments_DepartmentId",
                table: "TeachingAssistants",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingAssistants_Roles_RoleId",
                table: "TeachingAssistants",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicGrades_Courses_CourseId",
                table: "AcademicGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicGrades_Students_StudentId",
                table: "AcademicGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecords_Courses_CourseId",
                table: "AcademicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecords_Semesters_SemesterId",
                table: "AcademicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicRecords_Students_StudentId",
                table: "AcademicRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorCourses_Administrators_AdministratorsId",
                table: "AdministratorCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_AdministratorCourses_Courses_ManagedCoursesId",
                table: "AdministratorCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_Roles_RoleId",
                table: "Administrators");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Courses_CourseId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Books_BookId",
                table: "BookLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Students_StudentId",
                table: "BookLoans");

            migrationBuilder.DropForeignKey(
                name: "FK_Courseprof_Courses_CoursesId",
                table: "Courseprof");

            migrationBuilder.DropForeignKey(
                name: "FK_Courseprof_Professors_ProfessorsId",
                table: "Courseprof");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeachingAssistant_Courses_CoursesId",
                table: "CourseTeachingAssistant");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeachingAssistant_TeachingAssistants_TeachingAssistantsTeachingAssistantId",
                table: "CourseTeachingAssistant");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrollStudentInCourse_Courses_CourseId",
                table: "EnrollStudentInCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrollStudentInCourse_Semesters_SemesterId",
                table: "EnrollStudentInCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrollStudentInCourse_Students_StudentId",
                table: "EnrollStudentInCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Roles_RoleId",
                table: "Faculties");

            migrationBuilder.DropForeignKey(
                name: "FK_FinalGrades_Courses_CourseId",
                table: "FinalGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_FinalGrades_Students_StudentId",
                table: "FinalGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_Finances_Semesters_SemesterId",
                table: "Finances");

            migrationBuilder.DropForeignKey(
                name: "FK_Finances_Students_StudentId",
                table: "Finances");

            migrationBuilder.DropForeignKey(
                name: "FK_Grievances_Users_UserId",
                table: "Grievances");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassrooms_Semesters_SemesterId",
                table: "LectureClassrooms");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_Courses_CourseId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_LectureClassrooms_LectureClassroomId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_Professors_ProfessorId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureClassSchedules_Semesters_SemesterId",
                table: "LectureClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Departments_DepartmentId",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Roles_RoleId",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistrationGenerators_Students_StudentId",
                table: "RegistrationGenerators");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_Courses_CourseId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_SectionRooms_RoomId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_Semesters_SemesterId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionClassSchedules_TeachingAssistants_TeachingAssistantId",
                table: "SectionClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionRooms_Semesters_SemesterId",
                table: "SectionRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Roles_RoleId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingAssistants_Departments_DepartmentId",
                table: "TeachingAssistants");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingAssistants_Roles_RoleId",
                table: "TeachingAssistants");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicGrades_Courses_CourseId",
                table: "AcademicGrades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicGrades_Students_StudentId",
                table: "AcademicGrades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecords_Courses_CourseId",
                table: "AcademicRecords",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecords_Semesters_SemesterId",
                table: "AcademicRecords",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicRecords_Students_StudentId",
                table: "AcademicRecords",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorCourses_Administrators_AdministratorsId",
                table: "AdministratorCourses",
                column: "AdministratorsId",
                principalTable: "Administrators",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdministratorCourses_Courses_ManagedCoursesId",
                table: "AdministratorCourses",
                column: "ManagedCoursesId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_Roles_RoleId",
                table: "Administrators",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Courses_CourseId",
                table: "Attendances",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Books_BookId",
                table: "BookLoans",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Students_StudentId",
                table: "BookLoans",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courseprof_Courses_CoursesId",
                table: "Courseprof",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courseprof_Professors_ProfessorsId",
                table: "Courseprof",
                column: "ProfessorsId",
                principalTable: "Professors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeachingAssistant_Courses_CoursesId",
                table: "CourseTeachingAssistant",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeachingAssistant_TeachingAssistants_TeachingAssistantsTeachingAssistantId",
                table: "CourseTeachingAssistant",
                column: "TeachingAssistantsTeachingAssistantId",
                principalTable: "TeachingAssistants",
                principalColumn: "TeachingAssistantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollStudentInCourse_Courses_CourseId",
                table: "EnrollStudentInCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollStudentInCourse_Semesters_SemesterId",
                table: "EnrollStudentInCourse",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollStudentInCourse_Students_StudentId",
                table: "EnrollStudentInCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Roles_RoleId",
                table: "Faculties",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinalGrades_Courses_CourseId",
                table: "FinalGrades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinalGrades_Students_StudentId",
                table: "FinalGrades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Finances_Semesters_SemesterId",
                table: "Finances",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Finances_Students_StudentId",
                table: "Finances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grievances_Users_UserId",
                table: "Grievances",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassrooms_Semesters_SemesterId",
                table: "LectureClassrooms",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_Courses_CourseId",
                table: "LectureClassSchedules",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_LectureClassrooms_LectureClassroomId",
                table: "LectureClassSchedules",
                column: "LectureClassroomId",
                principalTable: "LectureClassrooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_Professors_ProfessorId",
                table: "LectureClassSchedules",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LectureClassSchedules_Semesters_SemesterId",
                table: "LectureClassSchedules",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Departments_DepartmentId",
                table: "Professors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Roles_RoleId",
                table: "Professors",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrationGenerators_Students_StudentId",
                table: "RegistrationGenerators",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_Courses_CourseId",
                table: "SectionClassSchedules",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_SectionRooms_RoomId",
                table: "SectionClassSchedules",
                column: "RoomId",
                principalTable: "SectionRooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_Semesters_SemesterId",
                table: "SectionClassSchedules",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionClassSchedules_TeachingAssistants_TeachingAssistantId",
                table: "SectionClassSchedules",
                column: "TeachingAssistantId",
                principalTable: "TeachingAssistants",
                principalColumn: "TeachingAssistantId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionRooms_Semesters_SemesterId",
                table: "SectionRooms",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Roles_RoleId",
                table: "Students",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingAssistants_Departments_DepartmentId",
                table: "TeachingAssistants",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingAssistants_Roles_RoleId",
                table: "TeachingAssistants",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
