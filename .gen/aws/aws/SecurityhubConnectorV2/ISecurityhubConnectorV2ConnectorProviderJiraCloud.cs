using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderJiraCloud), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderJiraCloud")]
    public interface ISecurityhubConnectorV2ConnectorProviderJiraCloud
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_connector_v2#project_key SecurityhubConnectorV2#project_key}.</summary>
        [JsiiProperty(name: "projectKey", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderJiraCloud), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderJiraCloud")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderJiraCloud
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/securityhub_connector_v2#project_key SecurityhubConnectorV2#project_key}.</summary>
            [JsiiProperty(name: "projectKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
