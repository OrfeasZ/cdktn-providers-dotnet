using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceCloudSqlDetails), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceCloudSqlDetails")]
    public interface IBdsBdsInstanceCloudSqlDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceCloudSqlDetails), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceCloudSqlDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstance.IBdsBdsInstanceCloudSqlDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
