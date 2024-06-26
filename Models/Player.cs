﻿using System;
using System.Collections.Generic;

namespace WebApplication9.Models;

public partial class Player
{
    public int Id { get; set; }

    public int IdGame { get; set; }

    public int IdUser { get; set; }

    public virtual Game? IdGameNavigation { get; set; } = null!;

    public virtual User? IdUserNavigation { get; set; } = null!;
}
