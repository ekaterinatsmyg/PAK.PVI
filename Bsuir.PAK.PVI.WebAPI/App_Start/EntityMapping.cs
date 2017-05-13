using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.WebAPI.App_Start
{
    public static class EntityMapping
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ExperimentEntity, ExperimentModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.ExperimentName, config => config.MapFrom(source => source.ExperimentName))
                    .ReverseMap();

                cfg.CreateMap<TestEntity, TestModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.TestName, config => config.MapFrom(source => source.TestName))
                    .ForMember(dest => dest.ExperimentId, config => config.MapFrom(source => source.ExperimentId))
                    .ReverseMap();

                cfg.CreateMap<ExperimentSettingsEntity, ExperimentSettingsModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.ExperimentId, config => config.MapFrom(source => source.ExperimentId))
                    .ForMember(dest => dest.SettingsState, config => config.MapFrom(source => source.SettingsState))
                    .ForMember(dest => dest.TimeBetweenTests,
                        config => config.MapFrom(source => source.TimeBetweenTests)).ReverseMap();

                cfg.CreateMap<TestSettingsEntity, TestSettingsModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.TestId, config => config.MapFrom(source => source.TestId))
                    .ForMember(dest => dest.SettingsSate, config => config.MapFrom(source => source.SettingsSate))
                    .ForMember(dest => dest.StimulusId, config => config.MapFrom(source => source.StimulusId))
                    .ForMember(dest => dest.TimeBetweenStimulus,
                        config => config.MapFrom(source => source.TimeBetweenStimulus))
                    .ForMember(dest => dest.TimeStimulus, config => config.MapFrom(source => source.TimeStimulus))
                    .ReverseMap();

                cfg.CreateMap<UserEntity, UserModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.Group, config => config.MapFrom(source => source.Group))
                    .ForMember(dest => dest.Password, config => config.MapFrom(source => source.Password))
                    .ForMember(dest => dest.Role, config => config.MapFrom(source => source.Role))
                    .ForMember(dest => dest.UserName, config => config.MapFrom(source => source.UserName)).ReverseMap();

                cfg.CreateMap<ResultsEntity, ResultModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.TestId, config => config.MapFrom(source => source.TestId))
                    .ForMember(dest => dest.ExperimentId, config => config.MapFrom(source => source.ExperimentId))
                    .ForMember(dest => dest.ExperimentSettingsId,
                        config => config.MapFrom(source => source.ExperimentSettingsId))
                    .ForMember(dest => dest.TestSettingsId, config => config.MapFrom(source => source.TestSettingsId))
                    .ForMember(dest => dest.UserId, config => config.MapFrom(source => source.UserId))
                    .ForMember(dest => dest.CreatedDate, config => config.MapFrom(source => source.CreatedDate))
                    .ForMember(dest => dest.Results, config => config.MapFrom(source => source.Result)).ReverseMap();

                cfg.CreateMap<StimulusEntity, StimulusModel>()
                    .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                    .ForMember(dest => dest.TestSettingsId, config => config.MapFrom(source => source.TestSettingsId))
                    .ForMember(dest => dest.RangeOfIncentives,
                        config => config.MapFrom(source => source.RangeOfIncentives))
                    .ForMember(dest => dest.CreatedDate, config => config.MapFrom(source => source.CreatedDate))
                    .ForMember(dest => dest.StimulusState, config => config.MapFrom(source => source.StimulusState))
                    .ReverseMap();


            });
        }
    }
}