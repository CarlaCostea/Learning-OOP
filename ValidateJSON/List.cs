﻿namespace ValidateJSON
{
    public class List : IPattern
    {
        private readonly IPattern pattern;

        public List(IPattern element, IPattern separator)
        {
            this.pattern = new Many(new Sequence(element, new Many(new Sequence(new Optional(element), new Optional(separator), new Optional(element)))));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
