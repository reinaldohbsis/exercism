using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        return nucleotide = nucleotide.Replace('A', 'U').Replace('T', 'A').Replace('G', 'X').Replace('C', 'G').Replace('X', 'C');
        
    }
}