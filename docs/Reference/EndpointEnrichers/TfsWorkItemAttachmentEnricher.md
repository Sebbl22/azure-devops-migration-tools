## EndpointEnrichers: TfsWorkItemAttachmentEnricher

>**_This documentation is for a preview version of the Azure DevOps Migration Tools._ If you are not using the preview version then please head over to the main [documentation](https://nkdagility.github.io/azure-devops-migration-tools).**

[Overview](.././index.md) > [Reference](../index.md) > [EndpointEnrichers](./index.md) > **TfsWorkItemAttachmentEnricher**

missing XML code comments

### Options

| Parameter name         | Type    | Description                              | Default Value                            |
|------------------------|---------|------------------------------------------|------------------------------------------|
| Enabled | Boolean | missing XML code comments | missing XML code comments |
| WorkingPath | String | missing XML code comments | missing XML code comments |
| MaxSize | Int32 | missing XML code comments | missing XML code comments |
| RefName | String | missing XML code comments | missing XML code comments |


### Example JSON

```JSON
{
  "$type": "TfsWorkItemAttachmentEnricherOptions",
  "Enabled": true,
  "WorkingPath": "c:\\temp\\WorkItemAttachmentWorkingFolder\\",
  "MaxSize": 480000000
}
```