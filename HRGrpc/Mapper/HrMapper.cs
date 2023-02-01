using AutoMapper;
using Google.Protobuf.WellKnownTypes;
using Hr.Zeth.Poc.API.Protos;
using Hr.Zeth.Poc.Shared.Entities;

namespace HRGrpc.Mapper
{
    public class HrMapper : Profile
    {
        public HrMapper()
        {
            CreateMap<HrOnboarding, OnboardingResponse>();
        }
    }
}
