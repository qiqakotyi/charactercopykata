using System.Linq;
using NSubstitute;
using CharacterCopyKata.Interfaces;
using CharacterCopyKata.Core;
using Xunit;

namespace CharacterCopyKata.Tests
{
    public class CopierTests
    {
        [Fact]
        public void Copy_ShouldCopyCharactersUntilNewline()
        {
            var source = Substitute.For<ISource>();
            var destination = Substitute.For<IDestination>();

            source.ReadChar().Returns('H', 'e', 'l', 'l', 'o', '\n');

            var copier = new Copier(source, destination);

            copier.Copy();

            destination.Received(1).WriteChar('H');
            destination.Received(1).WriteChar('e');
            destination.Received(2).WriteChar('l');
            destination.Received(1).WriteChar('o');
            destination.DidNotReceive().WriteChar('\n');
        }

        [Fact]
        public void CopyMultiple_ShouldCopyMultipleCharactersUntilNewline()
        {
            var source = Substitute.For<ISource>();
            var destination = Substitute.For<IDestination>();

            source.ReadChars(5).Returns(new[] { 'H', 'e', 'l', 'l', 'o' });

            var copier = new Copier(source, destination);

            copier.CopyMultiple(5);

            destination.Received(1).WriteChars(Arg.Is<char[]>(x => x.SequenceEqual(new[] { 'H', 'e', 'l', 'l', 'o' })));
        }

        [Fact]
        public void CopyMultiple_ShouldStopWhenNewlineIsEncountered()
        {
            var source = Substitute.For<ISource>();
            var destination = Substitute.For<IDestination>();

            source.ReadChars(10).Returns(new[] { 'H', 'e', 'l', 'l', 'o', '\n', 'W', 'o', 'r', 'l' });

            var copier = new Copier(source, destination);

            copier.CopyMultiple(10);

            destination.Received(1).WriteChars(Arg.Is<char[]>(x => x.SequenceEqual(new[] { 'H', 'e', 'l', 'l', 'o' })));
            destination.DidNotReceive().WriteChars(Arg.Is<char[]>(x => x.Contains('\n')));
        }
    }
}
