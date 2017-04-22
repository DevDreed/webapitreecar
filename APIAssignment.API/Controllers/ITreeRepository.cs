using APIAssignment.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssignment.API.Controllers
{
    public interface ITreeRepository
    {
        Tree GetTreeById(int id);

        List<Tree> GetAllTrees();

        void CreateNewTree(Tree tree);
    }
}
