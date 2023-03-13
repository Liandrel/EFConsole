using EFConsole.Context;
using EFConsole.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole;

public class App
{
    private readonly fooContext _context;

    public App(fooContext context)
    {
        _context = context;
    }
    public void Run()
    {
        AddPerson();
        List<PersonModel> people = GetPeople();

        foreach (PersonModel person in people)
        {
           Console.WriteLine($"{person.FirstName},{person.LastName}");
        }
        Console.ReadLine();
    }

    private void AddPerson()
    {
        _context.People.Add(new PersonModel()
        {
            FirstName = "John",
            LastName = "Smith",
            Age = 22,
            Address = new AddressModel()
            {
                Country = "Poland",
                City = "Warsaw",
                Region = "Wypiździejewo",
                PostalCode = "22-222"
            }
        });
        _context.SaveChanges();
    }

    private List<PersonModel> GetPeople()
    {
        var people = _context.People.ToList();
        return people;
    }
}
