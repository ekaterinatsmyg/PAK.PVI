using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Bsuir.PAK.PVI.DataAccessLayer.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces;
using Bsuir.PAK.PVI.DataAccessLayer.Repositories.Repositories;
using Bsuir.PAK.PVI.DataServices.Interfaces;
using Bsuir.PAK.PVI.DataServices.Services;
using Bsuir.PAK.PVI.UnityDependencyResolver;
using Unity.WebApi;

namespace Bsuir.PAK.PVI.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<DbContext, DbContextModel>();

            container.RegisterType<IExperimentRepository, ExperimentRepository>();
            container.RegisterType<IExperimentSettingsRepository, ExperimentSettingsRepository>();
            container.RegisterType<ITestRepository, TestRepository>();
            container.RegisterType<ITestSettingsRepository, TestSettingsRepository>();
            container.RegisterType<IStimulusRepository, StimulusRepository>();
            container.RegisterType<IUserResultRepository, UserResultRepository>();


            container.RegisterType<IExperimentService, ExperimentService>();
            container.RegisterType<IExperimentSettingsService, ExperimentSettingsService>();
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<ITestSettingsService, TestSettingsService>();
            container.RegisterType<IStimulusService, StimulusService>();
            container.RegisterType<IUserResultService, UserResultService>();


            GlobalConfiguration.Configuration.DependencyResolver = new  IoCContainer(container);
        }

        
    }
}