using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServiceendpointBitbucket
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsServiceendpointBitbucketTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointBitbucket.DataAzuredevopsServiceendpointBitbucketTimeouts")]
    public interface IDataAzuredevopsServiceendpointBitbucketTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_bitbucket#read DataAzuredevopsServiceendpointBitbucket#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsServiceendpointBitbucketTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsServiceendpointBitbucket.DataAzuredevopsServiceendpointBitbucketTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsServiceendpointBitbucket.IDataAzuredevopsServiceendpointBitbucketTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/serviceendpoint_bitbucket#read DataAzuredevopsServiceendpointBitbucket#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
