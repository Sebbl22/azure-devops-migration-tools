## Processors: TfsSharedQueryProcessor

>**_This documentation is for a preview version of the Azure DevOps Migration Tools._ If you are not using the preview version then please head over to the main [documentation](https://nkdagility.github.io/azure-devops-migration-tools).**

[Overview](.././index.md) > [Reference](../index.md) > [Processors](./index.md) > **TfsSharedQueryProcessor**

The TfsSharedQueryProcessor enabled you to migrate queries from one location to another.

### Options

| Parameter name         | Type    | Description                                                                                                                             | Default Value                            |
|------------------------|---------|-----------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------|
| Enabled | Boolean | If set to `true` then the processor will run. Set to `false` and the processor will not run.                                            | missing XML code comments |
| PrefixProjectToNodes | Boolean | Do we add the source project name into the folder path                                                                                  | false |
| SharedFolderName | String | The name of the shared folder, made a parameter in case it every needs to be edited                                                     | Shared Queries |
| SourceToTargetFieldMappings | Dictionary`2 | Mapping of the source to the target                                                                                                     | missing XML code comments |
| ProcessorEnrichers | List | List of Enrichers that can be used to add more features to this processor. Only works with Native Processors and not legacy Processors. | missing XML code comments |
| SourceName | String | missing XML code comments                                                                                                               | missing XML code comments |
| TargetName | String | missing XML code comments                                                                                                               | missing XML code comments |
| RefName | String | `Refname` will be used in the future to allow for using named Options without the need to copy all of the options.                      | missing XML code comments |


### Example JSON

```JSON
{
  "$type": "TfsSharedQueryProcessorOptions",
  "Enabled": false,
  "PrefixProjectToNodes": false,
  "SharedFolderName": "Shared Queries",
  "SourceToTargetFieldMappings": null,
  "ProcessorEnrichers": null,
  "SourceName": "sourceName",
  "TargetName": "targetName"
}
```