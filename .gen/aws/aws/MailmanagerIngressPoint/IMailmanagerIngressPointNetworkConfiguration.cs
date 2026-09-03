using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiInterface(nativeType: typeof(IMailmanagerIngressPointNetworkConfiguration), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfiguration")]
    public interface IMailmanagerIngressPointNetworkConfiguration
    {
        /// <summary>private_network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_ingress_point#private_network_configuration MailmanagerIngressPoint#private_network_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "privateNetworkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateNetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_ingress_point#public_network_configuration MailmanagerIngressPoint#public_network_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "publicNetworkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerIngressPointNetworkConfiguration), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>private_network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_ingress_point#private_network_configuration MailmanagerIngressPoint#private_network_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateNetworkConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>public_network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_ingress_point#public_network_configuration MailmanagerIngressPoint#public_network_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PublicNetworkConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
