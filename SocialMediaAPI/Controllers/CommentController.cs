using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaAPI.Controllers
{
    public class CommentController
    {
        public IHttpActionResult Get()
        {
            CommentService CommentService = CreateCommentService();
            var comments = CommentService.GetComments();
            return Ok(comments);
        }

        public IHttpActionResult Post(CommentCreate Comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(Comment))
                return InternalServerError();

            return Ok();
        }


        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var CommentService = new CommentService(userId);
            return CommentService;
        }
    }
}