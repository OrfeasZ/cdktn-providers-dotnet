using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackLbBackendAddressPool
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackLbBackendAddressPoolTimeouts), fullyQualifiedName: "azurestack.dataAzurestackLbBackendAddressPool.DataAzurestackLbBackendAddressPoolTimeouts")]
    public interface IDataAzurestackLbBackendAddressPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/lb_backend_address_pool#read DataAzurestackLbBackendAddressPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackLbBackendAddressPoolTimeouts), fullyQualifiedName: "azurestack.dataAzurestackLbBackendAddressPool.DataAzurestackLbBackendAddressPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackLbBackendAddressPool.IDataAzurestackLbBackendAddressPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/lb_backend_address_pool#read DataAzurestackLbBackendAddressPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
