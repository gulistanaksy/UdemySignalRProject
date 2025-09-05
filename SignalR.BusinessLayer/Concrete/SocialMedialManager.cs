using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class SocialMedialManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMedia;
        public SocialMedialManager(ISocialMediaDal socialMedia)
        {
            _socialMedia = socialMedia;
        }
        public void TAdd(SocialMedia entity)
        {
            _socialMedia.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMedia.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMedia.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialMedia.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMedia.Update(entity);
        }
    }
}
