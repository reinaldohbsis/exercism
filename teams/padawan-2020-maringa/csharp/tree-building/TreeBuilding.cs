using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }
}

public class Tree
{
    public int Id { get; set; } // Id da arvre
    public int ParentId { get; set; } 

    public List<Tree> Children { get; set; }

    public bool IsLeaf => Children.Count == 0; // Se o contador for 0, significa que não possui filhos e é uma folha
                                               // Senão, o jardineiro é jesus e as arvres samos nozis
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
    {
        var trees = new List<Tree>();
        var previousRecordId = 0;

        foreach (var record in records.OrderBy(x => x.RecordId))
        {
            var t = new Tree { Children = new List<Tree>(), Id = record.RecordId, ParentId = record.ParentId };

            trees.Add(t);

            if ((t.Id == 0 && t.ParentId != 0) ||
                (t.Id != 0 && t.ParentId >= t.Id) ||
                (t.Id != 0 && t.Id != previousRecordId))
                throw new ArgumentException();

            previousRecordId++;
        }

        if (trees.Count == 0)
        {
            throw new ArgumentException();
        }

        for (int i = 1; i < trees.Count; i++)
        {
            var t = trees.First(x => x.Id == i);
            var parent = trees.First(x => x.Id == t.ParentId);
            parent.Children.Add(t);
        }

        var r = trees.First(t => t.Id == 0);
        return r;
    }
}