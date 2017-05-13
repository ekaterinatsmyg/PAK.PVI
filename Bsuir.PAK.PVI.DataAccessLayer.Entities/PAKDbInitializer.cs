using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities
{
    public class PakDbInitializer : DropCreateDatabaseIfModelChanges<DbContextModel>
    {
        protected override void Seed(DbContextModel context)
        {
            IList<ExperimentEntity> experiments = new List<ExperimentEntity>()
            {
                new ExperimentEntity() { ExperimentName = "Эксперимент 1" },
                new ExperimentEntity() { ExperimentName = "Эксперимент 2" }
            };
            IList<TestEntity> tests = new List<TestEntity>()
            {
                new TestEntity() { ExperimentId = 1, TestName = "Опыт 1"},
                new TestEntity() {  ExperimentId = 1, TestName = "Опыт 2" },
                new TestEntity() {  ExperimentId = 1, TestName = "Опыт 3" },
                new TestEntity() {  ExperimentId = 2, TestName = "Опыт 1" }
            };
            IList<ExperimentSettingsEntity> experimentSettings = new List<ExperimentSettingsEntity>()
            {
                new ExperimentSettingsEntity() {ExperimentId = 1, SettingsState = SettingsState.Default, TimeBetweenTests =new TimeSpan(0, 5, 0) }
            };
            IList<StimulusEntity> stimuluses = new List<StimulusEntity>()
            {
                new StimulusEntity() {RangeOfIncentives = "", CreatedDate = DateTime.Now, StimulusState = StimulusState.Default},
                new StimulusEntity() {RangeOfIncentives = "", CreatedDate = DateTime.Now, StimulusState = StimulusState.Default},
                new StimulusEntity() {RangeOfIncentives = "", CreatedDate = DateTime.Now, StimulusState = StimulusState.Default}
            };
            IList<TestSettingsEntity> testSettings = new List<TestSettingsEntity>()
            {
                new TestSettingsEntity() {TestId = 1, SettingsSate = SettingsState.Default, TimeBetweenStimulus = new TimeSpan(0, 2, 30), TimeStimulus = new TimeSpan(0, 0, 15), StimulusId = 1},
                new TestSettingsEntity() {TestId = 2, SettingsSate = SettingsState.Default, TimeBetweenStimulus = new TimeSpan(0, 2, 30), TimeStimulus = new TimeSpan(0, 0, 15), StimulusId = 2},
                new TestSettingsEntity() {TestId = 3, SettingsSate = SettingsState.Default, TimeBetweenStimulus = new TimeSpan(0, 2, 30), TimeStimulus = new TimeSpan(0, 0, 15), StimulusId = 3},
                new TestSettingsEntity() {TestId = 4, SettingsSate = SettingsState.Default, TimeStimulus = new TimeSpan(0, 0, 2)}
            };
            foreach (ExperimentEntity experiment in experiments)
            {
                context.Set<ExperimentEntity>().Add(experiment);
            }
            foreach (ExperimentSettingsEntity experimentSetting in experimentSettings)
            {
                context.Set<ExperimentSettingsEntity>().Add(experimentSetting);
            }
            foreach (TestEntity test in tests)
            {
                context.Set<TestEntity>().Add(test);
            }
            foreach (TestSettingsEntity testSetting in testSettings)
            {
                context.Set<TestSettingsEntity>().Add(testSetting);
            }
            foreach (StimulusEntity stimulus in stimuluses)
            {
                context.Set<StimulusEntity>().Add(stimulus);
            }

            base.Seed(context);
        }
    }
}
