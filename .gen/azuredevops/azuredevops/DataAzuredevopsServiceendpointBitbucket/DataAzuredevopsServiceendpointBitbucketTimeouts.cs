using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointBitbucket
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServiceendpointBitbucket.DataAzuredevopsServiceendpointBitbucketTimeouts")]
    public class DataAzuredevopsServiceendpointBitbucketTimeouts : azuredevops.DataAzuredevopsServiceendpointBitbucket.IDataAzuredevopsServiceendpointBitbucketTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_bitbucket#read DataAzuredevopsServiceendpointBitbucket#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
