using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string, int> listaAlunos;

    public GradeSchool()
    {
        listaAlunos = new Dictionary<string, int>();
    }
    public void Add(string student, int grade)
    {
        listaAlunos.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        List<string> lista = new List<string>();
        var ordem = listaAlunos.OrderBy(q => q.Value).ThenBy(x => x.Key);
        foreach (var aluno in ordem)
        {
            lista.Add(aluno.Key);
        }
        return lista;
    }

    public IEnumerable<string> Grade(int grade)
    {
        List<string> lista = new List<string>();
        foreach(var aluno in listaAlunos)
        {
            if(aluno.Value == grade)
            {
                lista.Add(aluno.Key);
            }
        }
        return lista.OrderBy(x => x);
    }
}