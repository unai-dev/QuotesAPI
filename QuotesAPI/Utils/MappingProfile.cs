using AutoMapper;
using QuotesAPI.DTOs;
using QuotesAPI.Models;

namespace QuotesAPI.Utils
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateQuoteDTO, Quote>();
        }
    }
}
