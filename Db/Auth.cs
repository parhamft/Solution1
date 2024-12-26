using cw__17.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Auth
    {
        public static User? CurrentUser { get; set; }

    }
}
