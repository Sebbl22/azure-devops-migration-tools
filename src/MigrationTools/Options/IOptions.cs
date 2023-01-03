using System;
using Newtonsoft.Json;

namespace MigrationTools.Options
{
    public interface IOptions
    {
        /// <summary>
        /// If you set a `RefName` then this configuration will be added to a Catalog of configurations that can be referenced using tha `RefName` so that you dont have to keep adding the ame items with the same configuration.
        /// </summary>
        public string RefName { get; set; }

        [JsonIgnore]
        Type ToConfigure { get; }

        void SetDefaults();
    }
}