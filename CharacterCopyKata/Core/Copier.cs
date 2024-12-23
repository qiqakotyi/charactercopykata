﻿using CharacterCopyKata.Interfaces;

namespace CharacterCopyKata.Core
{
    public class Copier
    {
        private readonly ISource _source;
        private readonly IDestination _destination;
        public Copier(ISource source, IDestination destination)
        {
            _source = source;
            _destination = destination;
        }

        public void Copy()
        {
            char character;
            while ((character = _source.ReadChar()) != '\n')
            {
                _destination.WriteChar(character);
            }
        }
        public void CopyMultiple(int count)
        {
            char[] chars = _source.ReadChars(count);
            var truncated = chars.TakeWhile(c => c != '\n').ToArray();
            _destination.WriteChars(truncated);
        }
    }

}
