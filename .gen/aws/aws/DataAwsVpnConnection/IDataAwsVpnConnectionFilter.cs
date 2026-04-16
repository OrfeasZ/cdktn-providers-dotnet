using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpnConnection
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpnConnectionFilter), fullyQualifiedName: "aws.dataAwsVpnConnection.DataAwsVpnConnectionFilter")]
    public interface IDataAwsVpnConnectionFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/vpn_connection#name DataAwsVpnConnection#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/vpn_connection#values DataAwsVpnConnection#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpnConnectionFilter), fullyQualifiedName: "aws.dataAwsVpnConnection.DataAwsVpnConnectionFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpnConnection.IDataAwsVpnConnectionFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/vpn_connection#name DataAwsVpnConnection#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/data-sources/vpn_connection#values DataAwsVpnConnection#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
