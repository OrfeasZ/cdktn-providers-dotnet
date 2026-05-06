using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeCalculateAuditVolumeAvailable
{
    [JsiiInterface(nativeType: typeof(IDataSafeCalculateAuditVolumeAvailableConfig), fullyQualifiedName: "oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableConfig")]
    public interface IDataSafeCalculateAuditVolumeAvailableConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#audit_profile_id DataSafeCalculateAuditVolumeAvailable#audit_profile_id}.</summary>
        [JsiiProperty(name: "auditProfileId", typeJson: "{\"primitive\":\"string\"}")]
        string AuditProfileId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#audit_collection_start_time DataSafeCalculateAuditVolumeAvailable#audit_collection_start_time}.</summary>
        [JsiiProperty(name: "auditCollectionStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuditCollectionStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#database_unique_name DataSafeCalculateAuditVolumeAvailable#database_unique_name}.</summary>
        [JsiiProperty(name: "databaseUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseUniqueName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#id DataSafeCalculateAuditVolumeAvailable#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#timeouts DataSafeCalculateAuditVolumeAvailable#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#trail_locations DataSafeCalculateAuditVolumeAvailable#trail_locations}.</summary>
        [JsiiProperty(name: "trailLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrailLocations
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeCalculateAuditVolumeAvailableConfig), fullyQualifiedName: "oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#audit_profile_id DataSafeCalculateAuditVolumeAvailable#audit_profile_id}.</summary>
            [JsiiProperty(name: "auditProfileId", typeJson: "{\"primitive\":\"string\"}")]
            public string AuditProfileId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#audit_collection_start_time DataSafeCalculateAuditVolumeAvailable#audit_collection_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auditCollectionStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuditCollectionStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#database_unique_name DataSafeCalculateAuditVolumeAvailable#database_unique_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseUniqueName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#id DataSafeCalculateAuditVolumeAvailable#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#timeouts DataSafeCalculateAuditVolumeAvailable#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeCalculateAuditVolumeAvailable.DataSafeCalculateAuditVolumeAvailableTimeouts\"}", isOptional: true)]
            public oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeCalculateAuditVolumeAvailable.IDataSafeCalculateAuditVolumeAvailableTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_calculate_audit_volume_available#trail_locations DataSafeCalculateAuditVolumeAvailable#trail_locations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trailLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrailLocations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
