using MigrationTools.DataContracts;

namespace MigrationTools._EngineV1.Enrichers
{
    public interface IAttachmentMigrationEnricher
    {
        void ProcessAttachments(WorkItemData source, WorkItemData target, bool save = true);

        void CleanUpAfterSave();
    }
}