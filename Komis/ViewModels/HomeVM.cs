﻿using Komis.Models;
using System.Collections.Generic;

namespace Komis.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Samochod> Samochody { get; set; }
    }
}
