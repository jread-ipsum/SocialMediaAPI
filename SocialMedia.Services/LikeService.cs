using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    OwnerId = _userId,
                    Id = model.Id,
                    PostId = model.PostId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LikeByPostID> GetLikesByID(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Likes
                        .Where(e => e.OwnerId == _userId && e.PostId == postId) // also need to make sure we are grabbing the correct post
                        .Select(
                            e =>
                                new LikeByPostID
                                {
                                    PostId = e.PostId // might also want to include owner Id and Id of like
                                }
                        );
                return query.ToArray();
            }
        }
    }
}
