using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class SQLVideoDataService : IVideoDataRepository
    {
        private readonly VideoDbContext _videoDbContext;
        public SQLVideoDataService(VideoDbContext videoDbContext)
        {
            _videoDbContext = videoDbContext;
        }
        public void AddNewVideo(Video video)
        {
            _videoDbContext.Videos.Add(video);
            Commit();
        }
        public int Commit()
        {
            return _videoDbContext.SaveChanges();
        }
        public IEnumerable<Video> GetAll()
        {
            return _videoDbContext.Videos.ToList();
        }
        public Video GetVideoById(int id)
        {
            return _videoDbContext.Videos.Find(id);
        }
    }
}
