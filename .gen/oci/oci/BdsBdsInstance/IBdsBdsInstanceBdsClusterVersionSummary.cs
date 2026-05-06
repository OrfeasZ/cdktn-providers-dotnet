using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceBdsClusterVersionSummary), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummary")]
    public interface IBdsBdsInstanceBdsClusterVersionSummary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#bds_version BdsBdsInstance#bds_version}.</summary>
        [JsiiProperty(name: "bdsVersion", typeJson: "{\"primitive\":\"string\"}")]
        string BdsVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#odh_version BdsBdsInstance#odh_version}.</summary>
        [JsiiProperty(name: "odhVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OdhVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceBdsClusterVersionSummary), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceBdsClusterVersionSummary")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstance.IBdsBdsInstanceBdsClusterVersionSummary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#bds_version BdsBdsInstance#bds_version}.</summary>
            [JsiiProperty(name: "bdsVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#odh_version BdsBdsInstance#odh_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "odhVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OdhVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
