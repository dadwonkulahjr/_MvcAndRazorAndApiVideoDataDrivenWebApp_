using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public interface IVideoDataRepository
    {
        //Select all the videos...
        IEnumerable<Video> GetAll();
        Video GetVideoById(int id);
        //Create
        //Select base on the Id given

        //Commit ask save
        //Delete
        int Commit();
        void AddNewVideo(Video video);
    }
}
