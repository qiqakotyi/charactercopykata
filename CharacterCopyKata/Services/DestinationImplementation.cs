using CharacterCopyKata.Interfaces;
using System;
using System.Collections.Generic;

public class DestinationImplementation : IDestination
{
    private readonly List<char> _writtenData = new List<char>();

    public void WriteChar(char c)
    {
        _writtenData.Add(c);
        Console.WriteLine($"Character written: {c}");
    }

    public void WriteChars(char[] values)
    {
        foreach (var c in values)
        {
            if (c == '\n') break;
            _writtenData.Add(c);
            Console.WriteLine($"Character written: {c}");
        }
    }

    public string GetWrittenData()
    {
        return new string(_writtenData.ToArray());
    }
}
