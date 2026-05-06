using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeAuditProfileCollectedAuditVolumes
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeAuditProfileCollectedAuditVolumesConfig), fullyQualifiedName: "oci.dataOciDataSafeAuditProfileCollectedAuditVolumes.DataOciDataSafeAuditProfileCollectedAuditVolumesConfig")]
    public interface IDataOciDataSafeAuditProfileCollectedAuditVolumesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#audit_profile_id DataOciDataSafeAuditProfileCollectedAuditVolumes#audit_profile_id}.</summary>
        [JsiiProperty(name: "auditProfileId", typeJson: "{\"primitive\":\"string\"}")]
        string AuditProfileId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#work_request_id DataOciDataSafeAuditProfileCollectedAuditVolumes#work_request_id}.</summary>
        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkRequestId
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#filter DataOciDataSafeAuditProfileCollectedAuditVolumes#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeAuditProfileCollectedAuditVolumes.DataOciDataSafeAuditProfileCollectedAuditVolumesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#id DataOciDataSafeAuditProfileCollectedAuditVolumes#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#month_in_consideration_greater_than DataOciDataSafeAuditProfileCollectedAuditVolumes#month_in_consideration_greater_than}.</summary>
        [JsiiProperty(name: "monthInConsiderationGreaterThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonthInConsiderationGreaterThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#month_in_consideration_less_than DataOciDataSafeAuditProfileCollectedAuditVolumes#month_in_consideration_less_than}.</summary>
        [JsiiProperty(name: "monthInConsiderationLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonthInConsiderationLessThan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeAuditProfileCollectedAuditVolumesConfig), fullyQualifiedName: "oci.dataOciDataSafeAuditProfileCollectedAuditVolumes.DataOciDataSafeAuditProfileCollectedAuditVolumesConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeAuditProfileCollectedAuditVolumes.IDataOciDataSafeAuditProfileCollectedAuditVolumesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#audit_profile_id DataOciDataSafeAuditProfileCollectedAuditVolumes#audit_profile_id}.</summary>
            [JsiiProperty(name: "auditProfileId", typeJson: "{\"primitive\":\"string\"}")]
            public string AuditProfileId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#work_request_id DataOciDataSafeAuditProfileCollectedAuditVolumes#work_request_id}.</summary>
            [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkRequestId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#filter DataOciDataSafeAuditProfileCollectedAuditVolumes#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeAuditProfileCollectedAuditVolumes.DataOciDataSafeAuditProfileCollectedAuditVolumesFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#id DataOciDataSafeAuditProfileCollectedAuditVolumes#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#month_in_consideration_greater_than DataOciDataSafeAuditProfileCollectedAuditVolumes#month_in_consideration_greater_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monthInConsiderationGreaterThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonthInConsiderationGreaterThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_audit_profile_collected_audit_volumes#month_in_consideration_less_than DataOciDataSafeAuditProfileCollectedAuditVolumes#month_in_consideration_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monthInConsiderationLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonthInConsiderationLessThan
            {
                get => GetInstanceProperty<string?>();
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
