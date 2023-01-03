namespace MigrationTools._EngineV1.Configuration.FieldMap
{
    public class FieldToTagMapConfig : IFieldMapConfig
    {
        public string WorkItemTypeName { get; set; }
        public string sourceField { get; set; }
        public string formatExpression { get; set; }

        public string FieldMap
        {
            get
            {
                return "FieldToTagFieldMap";
            }
        }
    }
}