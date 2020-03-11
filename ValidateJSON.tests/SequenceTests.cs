using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class SequenceTests
    {
        [Fact]
        public void SequenceOfMatchingCharactersShoudReturnTrue()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('b')
            );
            var match = ab.Match("abcd");
            Assert.True(match.Success());
            Assert.Equal("cd", match.RemainingText());
        }

        [Fact]
        public void SequenceOfNotMatchingCharactersShoudReturnFalse()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('x')
            );
            var match = ab.Match("abcd");
            Assert.False(match.Success());
            Assert.Equal("abcd", match.RemainingText());
        }

        [Fact]
        public void NullShoudReturnFalse()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('x')
            );
            var match = ab.Match(null);
            Assert.False(match.Success());
            Assert.Null(match.RemainingText());
        }

        [Fact]
        public void EmptyStringShoudReturnFalse()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('x')
            );
            var match = ab.Match("");
            Assert.False(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void SequenceOfMatchingSequencesShouldReturnTrue()
        {
            var ab = new Sequence(
            new Character('a'),
            new Character('b')
        );
            var abc = new Sequence(
                ab,
                new Character('c')
            );
            var match = abc.Match("abcd");
            Assert.True(match.Success());
            Assert.Equal("d", match.RemainingText());
        }

        [Fact]
        public void SequenceOfNotMatchingSequencesShouldReturnFalse()
        {
            var ab = new Sequence(
            new Character('a'),
            new Character('b')
        );
            var abc = new Sequence(
                ab,
                new Character('c')
            );
            var match = abc.Match("abx");
            Assert.False(match.Success());
            Assert.Equal("abx", match.RemainingText());
        }

        [Fact]
        public void SequenceOfMatchingRepeteadSequencesShouldReturnTrue()
        {
            var hex = new Choice(
                new Range('0', '9'),
            
                new Range('a', 'f'),
                new Range('A', 'F')
            );

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var match = hexSeq.Match("u1234");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void SequenceOfMatchingRepeteadSequencesShouldReturnTrue1()
        {
            var hex = new Choice(
                new Range('0', '9'),

                new Range('a', 'f'),
                new Range('A', 'F')
            );

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var match = hexSeq.Match("uabcdef");
            Assert.True(match.Success());
            Assert.Equal("ef", match.RemainingText());
        }

        [Fact]
        public void SequenceOfMatchingRepeteadSequencesShouldReturnTrue2()
        {
            var hex = new Choice(
                new Range('0', '9'),

                new Range('a', 'f'),
                new Range('A', 'F')
            );

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var match = hexSeq.Match("uB005 ab");
            Assert.True(match.Success());
            Assert.Equal(" ab", match.RemainingText());
        }

        [Fact]
        public void SequenceOfNotMatchingRepeteadSequencesShouldReturnFalse()
        {
            var hex = new Choice(
                new Range('0', '9'),

                new Range('a', 'f'),
                new Range('A', 'F')
            );

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var match = hexSeq.Match("abc");
            Assert.False(match.Success());
            Assert.Equal("abc", match.RemainingText());
        }
    }
}
