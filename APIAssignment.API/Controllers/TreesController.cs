using APIAssignment.API.DAL;
using APIAssignment.API.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIAssignment.API.Controllers
{
    public class TreesController : ApiController
    {
        readonly ITreeRepository _treeRepo;

        public TreesController()
        {
            _treeRepo = new TreeRepository();
        }

        public TreesController(ITreeRepository treeRepo)
        {
            _treeRepo = treeRepo;
        }

        [HttpGet]
        [Route("api/tree/{id}")]
        public HttpResponseMessage TreeById(int id)
        {
            var tree = _treeRepo.GetTreeById(id);

            if (tree == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The tree with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, tree);
        }

        [HttpGet]
        [Route("api/tree")]
        public HttpResponseMessage AllTrees()
        {
            var trees = _treeRepo.GetAllTrees();

            if (trees.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"No trees returned");
            }

            return Request.CreateResponse(HttpStatusCode.OK, trees);
        }

        [HttpPost]
        [Route("api/tree")]
        public HttpResponseMessage PostTree([FromBody] Tree tree)
        {
            _treeRepo.CreateNewTree(tree);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
