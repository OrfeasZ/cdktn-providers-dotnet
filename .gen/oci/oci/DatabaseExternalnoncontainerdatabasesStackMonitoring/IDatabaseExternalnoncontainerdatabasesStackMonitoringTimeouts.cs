using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExternalnoncontainerdatabasesStackMonitoring
{
    [JsiiInterface(nativeType: typeof(IDatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts), fullyQualifiedName: "oci.databaseExternalnoncontainerdatabasesStackMonitoring.DatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts")]
    public interface IDatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#create DatabaseExternalnoncontainerdatabasesStackMonitoring#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#delete DatabaseExternalnoncontainerdatabasesStackMonitoring#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#update DatabaseExternalnoncontainerdatabasesStackMonitoring#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts), fullyQualifiedName: "oci.databaseExternalnoncontainerdatabasesStackMonitoring.DatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExternalnoncontainerdatabasesStackMonitoring.IDatabaseExternalnoncontainerdatabasesStackMonitoringTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#create DatabaseExternalnoncontainerdatabasesStackMonitoring#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#delete DatabaseExternalnoncontainerdatabasesStackMonitoring#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_externalnoncontainerdatabases_stack_monitoring#update DatabaseExternalnoncontainerdatabasesStackMonitoring#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
