﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScoreBoard {
    public class CheckSumScore {
        public static string CheckSum(string UserName, int points) {
            return UserName + points;
        }
    }
}
