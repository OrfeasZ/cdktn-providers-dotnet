using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderServiceNow), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderServiceNow")]
    public interface ISecurityhubConnectorV2ConnectorProviderServiceNow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#instance_name SecurityhubConnectorV2#instance_name}.</summary>
        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#secret_arn SecurityhubConnectorV2#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        string SecretArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderServiceNow), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderServiceNow")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderServiceNow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#instance_name SecurityhubConnectorV2#instance_name}.</summary>
            [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#secret_arn SecurityhubConnectorV2#secret_arn}.</summary>
            [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
