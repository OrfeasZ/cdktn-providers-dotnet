using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiInterface(nativeType: typeof(IInstancePrimaryNetworkInterface), fullyQualifiedName: "aws.instance.InstancePrimaryNetworkInterface")]
    public interface IInstancePrimaryNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#network_interface_id Instance#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkInterfaceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInstancePrimaryNetworkInterface), fullyQualifiedName: "aws.instance.InstancePrimaryNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, aws.Instance.IInstancePrimaryNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#network_interface_id Instance#network_interface_id}.</summary>
            [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkInterfaceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
