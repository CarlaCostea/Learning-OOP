﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateJSON
{
    public class Range
    {
        private readonly char start;
        private readonly char end;

        public Range(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public bool Match(string text)
        {
            return !string.IsNullOrEmpty(text);
        }
    }
}