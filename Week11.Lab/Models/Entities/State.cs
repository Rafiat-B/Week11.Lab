﻿using System;
using System.Collections.Generic;

namespace Week11.Lab.Models.Entities;

public partial class State
{
    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
