using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackNetworkSecurityGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackNetworkSecurityGroupTimeouts), fullyQualifiedName: "azurestack.dataAzurestackNetworkSecurityGroup.DataAzurestackNetworkSecurityGroupTimeouts")]
    public interface IDataAzurestackNetworkSecurityGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/network_security_group#read DataAzurestackNetworkSecurityGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackNetworkSecurityGroupTimeouts), fullyQualifiedName: "azurestack.dataAzurestackNetworkSecurityGroup.DataAzurestackNetworkSecurityGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackNetworkSecurityGroup.IDataAzurestackNetworkSecurityGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/network_security_group#read DataAzurestackNetworkSecurityGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
