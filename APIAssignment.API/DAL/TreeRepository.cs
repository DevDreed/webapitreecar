using APIAssignment.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIAssignment.API.Models;

namespace APIAssignment.API.DAL
{
    public class TreeRepository : ITreeRepository
    {

        private static List<Tree> trees = new List<Tree>();

        public void CreateNewTree(Tree tree)
        {
            trees.Add(tree);
        }

        public List<Tree> GetAllTrees()
        {
            return trees;
        }

        public Tree GetTreeById(int id)
        {
            return trees.FirstOrDefault(x => x.TreeId == id);
        }
    }
}