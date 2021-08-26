using Microsoft.AspNet.Identity;
using SocialMedia.Models.PostModels;
using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialMediaAPI.Controllers
{
    [Authorize]
    public class PostController : ApiController
    {
        public IHttpActionResult Get()
        {
            PostServices postServices = CreatePostService();
            var post = postServices.GetAllPost();
            return Ok(post);
        }
        public IHttpActionResult Post(PostCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePostService();

            if (!service.CreatePost(post))
                return InternalServerError();

            return Ok();
        }
        private PostServices CreatePostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var postServices = new PostServices(userId);
            return postServices;
        }
        //public IHttpActionResult Put(PostEdit post)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);
        //    var service = CreateNoteService();
        //
        //    if (!service.UpdatePost(post))
        //        return InternalServerError();
        //
        //    return Ok();
        //}
        //public IHttpActionResult Delete(int id)
        //{
        //    var service = CreateNoteService();
        //
        //    if (!service.DeletePost(id))
        //        return InternalServerError();
        //
        //    return Ok();
        //}
    }
}
