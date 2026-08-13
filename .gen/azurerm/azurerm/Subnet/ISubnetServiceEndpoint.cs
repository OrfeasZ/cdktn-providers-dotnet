using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Subnet
{
    [JsiiInterface(nativeType: typeof(ISubnetServiceEndpoint), fullyQualifiedName: "azurerm.subnet.SubnetServiceEndpoint")]
    public interface ISubnetServiceEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/subnet#service Subnet#service}.</summary>
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        string Service
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/subnet#network_identifier Subnet#network_identifier}.</summary>
        [JsiiProperty(name: "networkIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubnetServiceEndpoint), fullyQualifiedName: "azurerm.subnet.SubnetServiceEndpoint")]
        internal sealed class _Proxy : DeputyBase, azurerm.Subnet.ISubnetServiceEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/subnet#service Subnet#service}.</summary>
            [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
            public string Service
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/subnet#network_identifier Subnet#network_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
