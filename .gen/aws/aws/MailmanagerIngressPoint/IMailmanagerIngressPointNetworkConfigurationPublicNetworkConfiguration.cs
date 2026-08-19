using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiInterface(nativeType: typeof(IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration")]
    public interface IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#ip_type MailmanagerIngressPoint#ip_type}.</summary>
        [JsiiProperty(name: "ipType", typeJson: "{\"primitive\":\"string\"}")]
        string IpType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#ip_type MailmanagerIngressPoint#ip_type}.</summary>
            [JsiiProperty(name: "ipType", typeJson: "{\"primitive\":\"string\"}")]
            public string IpType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
