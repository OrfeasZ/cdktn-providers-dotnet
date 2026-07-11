using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackNetworkInterface
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackNetworkInterfaceTimeouts), fullyQualifiedName: "azurestack.dataAzurestackNetworkInterface.DataAzurestackNetworkInterfaceTimeouts")]
    public interface IDataAzurestackNetworkInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/network_interface#read DataAzurestackNetworkInterface#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackNetworkInterfaceTimeouts), fullyQualifiedName: "azurestack.dataAzurestackNetworkInterface.DataAzurestackNetworkInterfaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackNetworkInterface.IDataAzurestackNetworkInterfaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/network_interface#read DataAzurestackNetworkInterface#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
