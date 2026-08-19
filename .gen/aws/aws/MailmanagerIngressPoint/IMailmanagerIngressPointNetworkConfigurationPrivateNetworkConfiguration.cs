using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiInterface(nativeType: typeof(IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration")]
    public interface IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#vpc_endpoint_id MailmanagerIngressPoint#vpc_endpoint_id}.</summary>
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcEndpointId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#vpc_endpoint_id MailmanagerIngressPoint#vpc_endpoint_id}.</summary>
            [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
