using class_tutorial;

Student joe = new Student
{
    Id = 1,
    Firstname = "Joe",
    Age = 41,
    IsActive = true,
    DateCreated = new DateTime(2023, 2, 10)
};

Student jane = new Student
{
    Id = 2,
    Firstname = "Jane",
    Age = 31,
    IsActive = false,
    DateCreated = new DateTime(2023, 2, 13)
};

Student pat = new Student(101, "Pat", 22); //initialize an instance using a constructor

Console.WriteLine($"{pat.Id} | {pat.Firstname} | {pat.Age} | {pat.DateCreated}");

Console.WriteLine($"Instance Joe's first name is {joe.Firstname}"); // before executing a method to change Joe's name
joe.ChangeFirstName("Joseph");                                      // always have parentheses when defining or executing a method
Console.WriteLine($"Instance Joe's first name is {joe.Firstname}"); // after executing a method to change Joe's name

Console.WriteLine($"Instance Jane's age is {jane.Age}"); // before executing a method to change Jane's age
jane.IncrementAge();                                     // no parameters were passed to the IncrementAge method when defined so the
                                                         // parentheses stay empty
Console.WriteLine($"Instance Jane's age is {jane.Age}"); // after executing a method to change Jane's age

Console.WriteLine($"Instance Jane's date created is {jane.DateCreated}");          // before executing a method to add 30 days to Jane's date created
var JaneDateCreatedPlus30Days = jane.CalcCreateDatePlus30Days();                   // created a variable to hold the return of the CalcCreateDatePlus30Days method
Console.WriteLine($"Instance Jane's date created is {JaneDateCreatedPlus30Days}"); // after executing a method to change Jane's date created



Customer customer1 = new Customer();
customer1.AccountNumber = "A001";
customer1.Name = "Alphabet soup";
customer1.Email = "info@alphabetsoup.com";
customer1.Phone = "800-555-1212";

Customer customer2 = new Customer {
    AccountNumber = "B002",
    Name = "ButterflySongs",
    Email = "info@butterflysongs.com",
    Phone = "888-555-2121"
};

//Console.WriteLine($"Id           : {joe.Id}");
//Console.WriteLine($"Firstname    : {joe.Firstname}");
//Console.WriteLine($"Age          : {joe.Age}");
//Console.WriteLine($"IsActive     : {joe.IsActive}");
//Console.WriteLine($"DateCreated  : {joe.DateCreated}");

//Console.WriteLine(customer2.Name);





