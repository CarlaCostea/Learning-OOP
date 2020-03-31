﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidateJSON
{
    public class Choice : IPattern
    {
        private IPattern[] patterns;

        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            foreach (var pattern in patterns)
            {
                var match = pattern.Match(text);
                if (match.Success())
                {
                    return match;
                }
            }

            return new Match(text, false);
        }

        public void Add(IPattern pattern)
        {
            List<IPattern> list = patterns.ToList();
            list.Add(pattern);
            patterns = list.ToArray();
        }
    }
}
