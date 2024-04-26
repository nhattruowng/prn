﻿using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class Watch
{
    public int WatchId { get; set; }

    public string? WatchName { get; set; }

    public int? Price { get; set; }

    public string? Description { get; set; }

    public string? BrandId { get; set; }
}
