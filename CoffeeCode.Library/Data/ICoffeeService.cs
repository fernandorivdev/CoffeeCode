﻿namespace CoffeeCode.Library.Data;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
}
