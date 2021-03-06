﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class ChoiceTests
    {
        [Fact]
        public void MatchReturnsTrueForTextMatchingTheFirstChoicePattern()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            var match = digit.Match("0FE");
            Assert.True(match.Success());
            Assert.Equal("FE", match.RemainingText());
        }
        [Fact]
        public void MatchReturnsFalseForTextThatDoesNotMatchAnyChoicePatterns()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            var match = digit.Match("FE");
            Assert.False(match.Success());
            Assert.Equal("FE", match.RemainingText());
        }
        [Fact]
        public void MatchReturnsTrueForTextMatchingTheSecondChoicePattern()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            var match = digit.Match("1FE");
            Assert.True(match.Success());
            Assert.Equal("FE", match.RemainingText());
        }
        [Fact]
        public void MatchReturnsTrueForTextMatchingChoiceOfChoicesPatterns()
        {
            var digit = new Choice(
                 new Character('0'),
                 new Range('1', '9')
            );
            var hex = new Choice(
                    digit,
                    new Choice(
                        new Range('a', 'f'),
                        new Range('A', 'F')
                        )
            );
            var match = hex.Match("1FE");
            Assert.True(match.Success());
            Assert.Equal("FE", match.RemainingText());
        }

        [Fact]
        public void MatchReturnsFalseForTextNotMatchingChoiceOfChoicesPatterns()
        {
            var digit = new Choice(
                 new Character('0'),
                 new Range('1', '9')
            );
            var hex = new Choice(
                    digit,
                    new Choice(
                        new Range('a', 'f'),
                        new Range('A', 'F')
                        )
            );
            var match = hex.Match("gFE");
            Assert.False(match.Success());
            Assert.Equal("gFE", match.RemainingText());
        }
        [Fact]
        public void AddPattern()
        {
            var value = new Choice(
                        new String(),
                        new Number(),
                        new Text("true"),
                        new Text("false"),
                        new Text("null")
                    );

            var array = new Many(new Range('1', '9'));
            var @object = new Many(new Range('1', '9'));
            value.Add(array);
            value.Add(@object);
            var resultedValue = new Choice(
                        new String(),
                        new Number(),
                        new Text("true"),
                        new Text("false"),
                        new Text("null"), array, @object);
            Assert.Equal(value.ToString(), resultedValue.ToString());
        }
    }
}
