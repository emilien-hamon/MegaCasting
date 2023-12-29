using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MegaCasting.Class;

public partial class User
{
    public int Id { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime BirhDate { get; set; }
}
