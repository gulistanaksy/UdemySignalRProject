using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping: Profile
    {
        public TestimonialMapping()
        {
            CreateMap<TestimonialMapping, ResultTestimonialDto>().ReverseMap();
            CreateMap<TestimonialMapping, CreateTestimonialDto>().ReverseMap();
            CreateMap<TestimonialMapping, UpdateTestimonialDto>().ReverseMap();
            CreateMap<TestimonialMapping, GetTestimonialDto>().ReverseMap();
        }
    }
}
