using System;
using System.Web;

namespace WebApplication2
{
    public partial class Optional_Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check for query parameters
            if (!string.IsNullOrEmpty(Request.QueryString["action"]))
            {
                string action = Request.QueryString["action"];

                // Retrieve user ID from the cookie
                HttpCookie userIdCookie = Request.Cookies["UserID"];
                if (userIdCookie != null)
                {
                    int userId = Convert.ToInt32(userIdCookie.Value);

                    // Perform different actions based on the value of the 'action' parameter
                    switch (action)
                    {
                        case "viewOptionalCourses":
                         
                            break;

                        case "viewAvailableCourses":
                            
                            break;

                        case "viewRequiredCourses":
                           
                            break;

                        case "viewMissingCourses":
                            
                            break;

                        case "sendCourseRequest":
                            // Perform action for viewing optional courses
                            // Example: Populate GridView with optional courses
                            // You can use the userId as needed
                            break;

                        case "sendCreditHourRequest":
                            // Perform action for viewing available courses
                            // Example: Populate GridView with available courses
                            // You can use the userId as needed
                            break;

                        case "viewGraduationPlan":
                            // Perform action for viewing optional courses
                            // Example: Populate GridView with optional courses
                            // You can use the userId as needed
                            break;

                        case "viewUpcomingInstallment":
                            // Perform action for viewing available courses
                            // Example: Populate GridView with available courses
                            // You can use the userId as needed
                            break;

                        case "viewAllCoursesWithExamsDetails":
                            // Perform action for viewing optional courses
                            // Example: Populate GridView with optional courses
                            // You can use the userId as needed
                            break;

                        case "registerFirstMakeupExam":
                            // Perform action for viewing available courses
                            // Example: Populate GridView with available courses
                            // You can use the userId as needed
                            break;

                        case "registerSecondMakeupExam":
                            // Perform action for viewing optional courses
                            // Example: Populate GridView with optional courses
                            // You can use the userId as needed
                            break;

                        case "viewAllCoursesWithSlotsAndInstructors":
                            // Perform action for viewing available courses
                            // Example: Populate GridView with available courses
                            // You can use the userId as needed
                            break;

                        case "viewSlotsOfCourseByInstructor":
                            // Perform action for viewing optional courses
                            // Example: Populate GridView with optional courses
                            // You can use the userId as needed
                            break;

                        case "chooseInstructorForCourse":
                            // Perform action for viewing available courses
                            // Example: Populate GridView with available courses
                            // You can use the userId as needed
                            break;

                        case "viewAllCoursesWithPrerequisites":
                            // Perform action for viewing available courses
                            // Example: Populate GridView with available courses
                            // You can use the userId as needed
                            break;

                        // Add cases for other actions as needed

                        default:
                            break;
                    }
                }
            }
        }

        protected void returnHome(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}
