using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackRouteTable
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackRouteTableTimeouts), fullyQualifiedName: "azurestack.dataAzurestackRouteTable.DataAzurestackRouteTableTimeouts")]
    public interface IDataAzurestackRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/route_table#read DataAzurestackRouteTable#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackRouteTableTimeouts), fullyQualifiedName: "azurestack.dataAzurestackRouteTable.DataAzurestackRouteTableTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackRouteTable.IDataAzurestackRouteTableTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/route_table#read DataAzurestackRouteTable#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
