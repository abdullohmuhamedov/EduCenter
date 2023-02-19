//using EduCenter.Domain.Entities;
//using EduCenter.Domain.Enums;
//using EduCenter.Service.DTOs;
//using EduCenter.Service.Services;
//using System;

//namespace EduCenter
//{
//    public class CreateStudent
//    {
//        StudentService studentService = new StudentService();
//        public async void Create()
//        {
//            var student = new StudentCreationDto();
//            Console.Clear();
//            Console.Write("FirstName: ");
//            student.FirstName = Console.ReadLine();
//            Console.Write("LastName: ");
//            student.LastName = Console.ReadLine();
//            Console.Write("Date of Birth (dd.MM.YYYY): ");
//            student.DateOfBirth = DateTime.Parse(Console.ReadLine());
//            Console.Clear();
//            Console.WriteLine("1.Math");
//            Console.WriteLine("2.English");
//            Console.WriteLine("3.Biology");
//            Console.WriteLine("4.Chemistry");
//            Console.WriteLine("5.History");
//            Console.WriteLine("6.Russian");
//            Console.WriteLine("7.Arabic");

//            Console.Write("\n Which subject? ");
//            byte subjectKey = byte.Parse(Console.ReadLine());
//            switch (subjectKey)
//            {
//                case 1:
//                    student.Type = SubjectType.Math;
//                    break;
//                case 2:
//                    student.Type = SubjectType.English;
//                    break;
//                case 3:
//                    student.Type = SubjectType.Biology;
//                    break;
//                case 4:
//                    student.Type = SubjectType.Chemistry;
//                    break;
//                case 5:
//                    student.Type = SubjectType.History;
//                    break;
//                case 6:
//                    student.Type = SubjectType.Russian;
//                    break;
//                case 7:
//                    student.Type = SubjectType.Arabic;
//                    break;
//                default:
//                    Console.WriteLine("EROR");
//                    break;
//            }
//            var response = await studentService.CreateAsync(student);


//            Console.WriteLine($"\nCode: {response.StatusCode}\nMessage: {response.Message}");
//        }
//    }
//    public class DeleteStudent
//    {
//        StudentService studentService = new StudentService();

//        public async void Delete()
//        {
//            Console.Clear();
//            Console.Write("Enter Id -->  ");
//            int id = int.Parse(Console.ReadLine());
//            var response = await studentService.DeleteAsync(id);

//            Console.WriteLine($"\nCode: {response.StatusCode}\nMessage: {response.Message}");

//        }
//    }
//    public class GetAllBySubject
//    {
//        StudentService studentService = new StudentService();

//        public async void GetAll()
//        {
//            Console.Clear();
//            Console.WriteLine("1.Math");
//            Console.WriteLine("2.English");
//            Console.WriteLine("3.Biology");
//            Console.WriteLine("4.Chemistry");
//            Console.WriteLine("5.History");
//            Console.WriteLine("6.Russian");
//            Console.WriteLine("7.Arabic");

//            Console.Write("\n Which students do you want see? -->");
//            byte pressKey = byte.Parse(Console.ReadLine());
//            var response = await studentService.GetAllAsync(p => p.SubjectType == (SubjectType.Chemistry));

//            var lists = response.Students.ToList();
//            foreach (var list in lists)
//            {
//                Console.WriteLine($"{list.Id} ||{list.FirstName}\t||{list.LastName}\t||{list.DateOfBirth}\t||" +
//                    $"{list.SubjectType}\t||{list.AddedAt}");
//            }

//        }
//    }
//    public class GetPaidStudents
//    {
//        PaidStudentService paidStudentService = new PaidStudentService();

//        public async void GetAll()
//        {
//            Console.Clear();
//            var response = await paidStudentService.GetAllPaidStudentAsync();

//            var lists = response.PaidStudents.ToList();
//            foreach (var list in lists)
//            {
//                Console.WriteLine($"{list.Id} ||{list.FirstName}\t||{list.LastName}\t||{list.DateOfBirth}\t||" +
//                    $"{list.SubjectType}\t||{list.PaidAt}\t||{list.PaymentType}");
//            }
//        }
//    }
//    public class Payment
//    {
//        PaidStudentService paidStudentService = new PaidStudentService();

//        public async void Pay()
//        {
//            Console.Clear();
//            var paidStudent = new PaymentCreationDto();
//            Console.Write("Enter ID: ");
//            paidStudent.Id = int.Parse(Console.ReadLine());
//            Console.Write("Amount: ");
//            Console.Write("Paid For (MM.YYYY): ");
//            Console.Clear();
//            Console.WriteLine("1.Cash");
//            Console.WriteLine("2.UzCard");
//            Console.WriteLine("3.Humo");
//            Console.WriteLine("4.VISA");
//            Console.WriteLine("5.MasterCard");
//            Console.Write("\nPaymentType: ");
//            byte paymentType = byte.Parse(Console.ReadLine());
//            switch (paymentType)
//            {
//                case 1:
//                    paidStudent.Type = PaymentType.Cash;
//                    break;
//                case 2:
//                    paidStudent.Type = PaymentType.Humo;
//                    break;
//                case 3:
//                    paidStudent.Type = PaymentType.Uzcard;
//                    break;
//                case 4:
//                    paidStudent.Type = PaymentType.MasterCard;
//                    break;
//                case 5:
//                    paidStudent.Type = PaymentType.VISA;
//                    break;
//            }

//            var response = await paidStudentService.AddPaymentAsync(paidStudent.Id, paidStudent);
//            Console.WriteLine($"\nCode: {response.StatusCode}\nMessage: {response.Message}");


//        }

//    }
//    public class PressButton
//    {
//        public void Start()
//        {
//        Start:
//            Console.WriteLine("1.Create new student");
//            Console.WriteLine("2.Delete student");
//            Console.WriteLine("3.Search student");
//            Console.WriteLine("4.Search student by learning subject");
//            Console.WriteLine("5.Payment");
//            Console.WriteLine("6.Get Paid Students");


//            Console.Write("\nChoose your purpose --> ");
//            byte pressKey = byte.Parse(Console.ReadLine());
//            switch (pressKey)
//            {
//                case 1:
//                    var createStudent = new CreateStudent();
//                    createStudent.Create();
//                    Menu();
//                    goto Start;
//                case 2:
//                    var deleteStudent = new DeleteStudent();
//                    deleteStudent.Delete();
//                    Menu();
//                    goto Start;
//                case 3:
//                    var searchStudent = new SearchStudent();
//                    searchStudent.Search();
//                    Menu();
//                    goto Start;
//                case 4:
//                    var getStudents = new GetAllBySubject();
//                    getStudents.GetAll();
//                    Menu();
//                    goto Start;
//                case 5:
//                    var payment = new Payment();
//                    payment.Pay();
//                    Menu();
//                    goto Start;
//                case 6:
//                    var getPaidStudsnts = new GetPaidStudents();
//                    getPaidStudsnts.GetAll();
//                    Menu();
//                    goto Start;
//                default:
//                    Menu();
//                    goto Start;

//            }
//        }

//        public static void Menu()
//        {
//            Console.WriteLine("\nPress any key to return to Main Menu!");
//            Console.ReadKey();
//            Console.Clear();
//        }
//    }
//    public class SearchStudent
//    {
//        StudentService studentService = new StudentService();

//        public async void Search()
//        {
//            Console.Clear();
//            Console.Write("Enter Id -->  ");
//            int id = int.Parse(Console.ReadLine());
//            var response = await studentService.GetByIdAsync(id);

//            Console.WriteLine($"\nCode: {response.StatusCode}\nMessage: {response.Message}\n");

//            var student = response.PaidStudent;
//            Console.WriteLine($"Id: {student.Id}\nFirstName: {student.FirstName}\nLastName: {student.LastName}\n" +
//                $"Date of Birth: {student.DateOfBirth}\nSubject Type: {student.SubjectType}\nCreatedAt: {student.AddedAt}");

//        }
//    }

//}
