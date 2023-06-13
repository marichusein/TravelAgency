﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TuristickaAgencija.Helpers
{
    public static class Extension
    {
        public static string ToBase64(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static byte[] parseBase64(this string base64)
        {
            return Convert.FromBase64String(base64);
        }
    }
}
