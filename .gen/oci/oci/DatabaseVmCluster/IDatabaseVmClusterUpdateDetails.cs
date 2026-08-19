using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterUpdateDetails), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterUpdateDetails")]
    public interface IDatabaseVmClusterUpdateDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_vm_cluster#update_action DatabaseVmCluster#update_action}.</summary>
        [JsiiProperty(name: "updateAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_vm_cluster#update_id DatabaseVmCluster#update_id}.</summary>
        [JsiiProperty(name: "updateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_vm_cluster#update_mode DatabaseVmCluster#update_mode}.</summary>
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterUpdateDetails), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterUpdateDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmCluster.IDatabaseVmClusterUpdateDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_vm_cluster#update_action DatabaseVmCluster#update_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_vm_cluster#update_id DatabaseVmCluster#update_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_vm_cluster#update_mode DatabaseVmCluster#update_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
