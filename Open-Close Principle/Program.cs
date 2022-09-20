

// See https://aka.ms/new-console-template for more information
using OCPLibrary;
using OCPLibrary.Applicants;

List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new PersonModel {FirstName="Tim", LastName="Corey"},
    new ManagerModel {FirstName="Sue", LastName="Storm"},
    new ExecutiveModel {FirstName="Nancy", LastName="Roman"}
};


List<EmployeeModel> employees = new List<EmployeeModel>();


foreach(var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach(var emp in employees)
{
    Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager {emp.IsManager} IsExecutive: {emp.IsExecutive}");
}



