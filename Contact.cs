﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExercise;

public class Contact
{
    private static int Counter = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int PhoneNumber { get; set; }
    public int Age { get; set; }

    public Contact()
    {
        Id = Counter++;
    } 
    public override string ToString()
    {
        return $"Name:{Name}\t" +
               $"Surname: {Surname}\t" +
               $"Age: {Age}\t" +
               $"Phone Number: {PhoneNumber}\t" +
               $"Id:{Id}\t";
    }
}