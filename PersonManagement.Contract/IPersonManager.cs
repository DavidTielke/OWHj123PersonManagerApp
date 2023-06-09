﻿using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Logic.Domain.PersonManagement.Contract;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}