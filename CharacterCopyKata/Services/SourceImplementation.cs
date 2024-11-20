using CharacterCopyKata.Interfaces;
using System.Collections.Generic;

public class SourceImplementation : ISource
{
    private readonly Queue<char> _data;

    public SourceImplementation(string input)
    {
        _data = new Queue<char>(input.ToCharArray());
    }

    public char ReadChar()
    {
        return _data.Count > 0 ? _data.Dequeue() : '\n';
    }

    public char[] ReadChars(int count)
    {
        var result = new List<char>();
        for (int i = 0; i < count && _data.Count > 0; i++)
        {
            var c = _data.Dequeue();
            if (c == '\n') break;
            result.Add(c);
        }
        return result.ToArray();
    }
}
