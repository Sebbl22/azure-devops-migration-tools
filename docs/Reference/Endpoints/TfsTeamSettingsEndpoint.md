## Endpoints: TfsTeamSettingsEndpoint

>**_This documentation is for a preview version of the Azure DevOps Migration Tools._ If you are not using the preview version then please head over to the main [documentation](https://nkdagility.github.io/azure-devops-migration-tools).**

[Overview](.././index.md) > [Reference](../index.md) > [Endpoints](./index.md) > **TfsTeamSettingsEndpoint**

missing XML code comments

### Options

| Parameter name         | Type    | Description                              | Default Value                            |
|------------------------|---------|------------------------------------------|------------------------------------------|
| Organisation | String | missing XML code comments | missing XML code comments |
| Project | String | missing XML code comments | missing XML code comments |
| AuthenticationMode | AuthenticationMode | missing XML code comments | missing XML code comments |
| AccessToken | String | missing XML code comments | missing XML code comments |
| ReflectedWorkItemIdField | String | missing XML code comments | missing XML code comments |
| LanguageMaps | TfsLanguageMapOptions | missing XML code comments | missing XML code comments |
| EndpointEnrichers | List | missing XML code comments | missing XML code comments |
| RefName | String | missing XML code comments | missing XML code comments |


### Example JSON

```JSON
{
  "$type": "TfsTeamSettingsEndpointOptions",
  "Organisation": "https://dev.azure.com/nkdagility-preview/",
  "Project": "NeedToSetThis",
  "AuthenticationMode": "AccessToken",
  "AccessToken": "6i4jyylsadkjanjniaydxnjsi4zsz3qarxhl2y5ngzzffiqdostq",
  "ReflectedWorkItemIdField": "Custom.ReflectedWorkItemId",
  "LanguageMaps": {
    "$type": "TfsLanguageMapOptions",
    "AreaPath": "Area",
    "IterationPath": "Iteration"
  },
  "EndpointEnrichers": null
}
```