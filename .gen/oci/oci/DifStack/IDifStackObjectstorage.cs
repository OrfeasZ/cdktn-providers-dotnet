using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackObjectstorage), fullyQualifiedName: "oci.difStack.DifStackObjectstorage")]
    public interface IDifStackObjectstorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#object_versioning DifStack#object_versioning}.</summary>
        [JsiiProperty(name: "objectVersioning", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectVersioning
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#storage_tier DifStack#storage_tier}.</summary>
        [JsiiProperty(name: "storageTier", typeJson: "{\"primitive\":\"string\"}")]
        string StorageTier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#auto_tiering DifStack#auto_tiering}.</summary>
        [JsiiProperty(name: "autoTiering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoTiering
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackObjectstorage), fullyQualifiedName: "oci.difStack.DifStackObjectstorage")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackObjectstorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#object_versioning DifStack#object_versioning}.</summary>
            [JsiiProperty(name: "objectVersioning", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectVersioning
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#storage_tier DifStack#storage_tier}.</summary>
            [JsiiProperty(name: "storageTier", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageTier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/dif_stack#auto_tiering DifStack#auto_tiering}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoTiering", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoTiering
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
