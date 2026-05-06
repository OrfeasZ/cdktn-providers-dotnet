using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementExternalDbSystem
{
    [JsiiInterface(nativeType: typeof(IDatabaseManagementExternalDbSystemStackMonitoringConfig), fullyQualifiedName: "oci.databaseManagementExternalDbSystem.DatabaseManagementExternalDbSystemStackMonitoringConfig")]
    public interface IDatabaseManagementExternalDbSystemStackMonitoringConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#is_enabled DatabaseManagementExternalDbSystem#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#metadata DatabaseManagementExternalDbSystem#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseManagementExternalDbSystemStackMonitoringConfig), fullyQualifiedName: "oci.databaseManagementExternalDbSystem.DatabaseManagementExternalDbSystemStackMonitoringConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseManagementExternalDbSystem.IDatabaseManagementExternalDbSystemStackMonitoringConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#is_enabled DatabaseManagementExternalDbSystem#is_enabled}.</summary>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_management_external_db_system#metadata DatabaseManagementExternalDbSystem#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metadata
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
