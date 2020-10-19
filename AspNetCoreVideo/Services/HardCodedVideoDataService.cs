using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class HardCodedVideoDataService : IVideoDataRepository
    {
        private readonly List<Video> _videos;

        public HardCodedVideoDataService()
        {
            _videos = new List<Video>()
            {
              new Video() {Id = 1, Title = "Shreck", Genre = ViewModels.Genres.Comedy},
              new Video() {Id = 2, Title = "Despicable Me", Genre = ViewModels.Genres.Action },
              new Video() {Id = 3, Title = "Megamind", Genre = ViewModels.Genres.Animated }
            };
        }

        public void AddNewVideo(Video video)
        {
            video.Id = _videos.Max(v => v.Id) + 1;
            _videos.Add(video);
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }

        public Video GetVideoById(int id)
        {
            return _videos.FirstOrDefault(v => v.Id.Equals(id));
        }
    }

}

