using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OperatorAccessControlOperatorControlAssignment
{
    [JsiiInterface(nativeType: typeof(IOperatorAccessControlOperatorControlAssignmentConfig), fullyQualifiedName: "oci.operatorAccessControlOperatorControlAssignment.OperatorAccessControlOperatorControlAssignmentConfig")]
    public interface IOperatorAccessControlOperatorControlAssignmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#compartment_id OperatorAccessControlOperatorControlAssignment#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_enforced_always OperatorAccessControlOperatorControlAssignment#is_enforced_always}.</summary>
        [JsiiProperty(name: "isEnforcedAlways", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnforcedAlways
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#operator_control_id OperatorAccessControlOperatorControlAssignment#operator_control_id}.</summary>
        [JsiiProperty(name: "operatorControlId", typeJson: "{\"primitive\":\"string\"}")]
        string OperatorControlId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_compartment_id OperatorAccessControlOperatorControlAssignment#resource_compartment_id}.</summary>
        [JsiiProperty(name: "resourceCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceCompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_id OperatorAccessControlOperatorControlAssignment#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_name OperatorAccessControlOperatorControlAssignment#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_type OperatorAccessControlOperatorControlAssignment#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#comment OperatorAccessControlOperatorControlAssignment#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#defined_tags OperatorAccessControlOperatorControlAssignment#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#freeform_tags OperatorAccessControlOperatorControlAssignment#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#id OperatorAccessControlOperatorControlAssignment#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_auto_approve_during_maintenance OperatorAccessControlOperatorControlAssignment#is_auto_approve_during_maintenance}.</summary>
        [JsiiProperty(name: "isAutoApproveDuringMaintenance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutoApproveDuringMaintenance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_hypervisor_log_forwarded OperatorAccessControlOperatorControlAssignment#is_hypervisor_log_forwarded}.</summary>
        [JsiiProperty(name: "isHypervisorLogForwarded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHypervisorLogForwarded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_log_forwarded OperatorAccessControlOperatorControlAssignment#is_log_forwarded}.</summary>
        [JsiiProperty(name: "isLogForwarded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsLogForwarded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#remote_syslog_server_address OperatorAccessControlOperatorControlAssignment#remote_syslog_server_address}.</summary>
        [JsiiProperty(name: "remoteSyslogServerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteSyslogServerAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#remote_syslog_server_ca_cert OperatorAccessControlOperatorControlAssignment#remote_syslog_server_ca_cert}.</summary>
        [JsiiProperty(name: "remoteSyslogServerCaCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteSyslogServerCaCert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#remote_syslog_server_port OperatorAccessControlOperatorControlAssignment#remote_syslog_server_port}.</summary>
        [JsiiProperty(name: "remoteSyslogServerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RemoteSyslogServerPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#time_assignment_from OperatorAccessControlOperatorControlAssignment#time_assignment_from}.</summary>
        [JsiiProperty(name: "timeAssignmentFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeAssignmentFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#time_assignment_to OperatorAccessControlOperatorControlAssignment#time_assignment_to}.</summary>
        [JsiiProperty(name: "timeAssignmentTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeAssignmentTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#timeouts OperatorAccessControlOperatorControlAssignment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.operatorAccessControlOperatorControlAssignment.OperatorAccessControlOperatorControlAssignmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OperatorAccessControlOperatorControlAssignment.IOperatorAccessControlOperatorControlAssignmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#validate_assignment_trigger OperatorAccessControlOperatorControlAssignment#validate_assignment_trigger}.</summary>
        [JsiiProperty(name: "validateAssignmentTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidateAssignmentTrigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOperatorAccessControlOperatorControlAssignmentConfig), fullyQualifiedName: "oci.operatorAccessControlOperatorControlAssignment.OperatorAccessControlOperatorControlAssignmentConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OperatorAccessControlOperatorControlAssignment.IOperatorAccessControlOperatorControlAssignmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#compartment_id OperatorAccessControlOperatorControlAssignment#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_enforced_always OperatorAccessControlOperatorControlAssignment#is_enforced_always}.</summary>
            [JsiiProperty(name: "isEnforcedAlways", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnforcedAlways
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#operator_control_id OperatorAccessControlOperatorControlAssignment#operator_control_id}.</summary>
            [JsiiProperty(name: "operatorControlId", typeJson: "{\"primitive\":\"string\"}")]
            public string OperatorControlId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_compartment_id OperatorAccessControlOperatorControlAssignment#resource_compartment_id}.</summary>
            [JsiiProperty(name: "resourceCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceCompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_id OperatorAccessControlOperatorControlAssignment#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_name OperatorAccessControlOperatorControlAssignment#resource_name}.</summary>
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#resource_type OperatorAccessControlOperatorControlAssignment#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#comment OperatorAccessControlOperatorControlAssignment#comment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#defined_tags OperatorAccessControlOperatorControlAssignment#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#freeform_tags OperatorAccessControlOperatorControlAssignment#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#id OperatorAccessControlOperatorControlAssignment#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_auto_approve_during_maintenance OperatorAccessControlOperatorControlAssignment#is_auto_approve_during_maintenance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAutoApproveDuringMaintenance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutoApproveDuringMaintenance
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_hypervisor_log_forwarded OperatorAccessControlOperatorControlAssignment#is_hypervisor_log_forwarded}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHypervisorLogForwarded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHypervisorLogForwarded
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#is_log_forwarded OperatorAccessControlOperatorControlAssignment#is_log_forwarded}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isLogForwarded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsLogForwarded
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#remote_syslog_server_address OperatorAccessControlOperatorControlAssignment#remote_syslog_server_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteSyslogServerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteSyslogServerAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#remote_syslog_server_ca_cert OperatorAccessControlOperatorControlAssignment#remote_syslog_server_ca_cert}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteSyslogServerCaCert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteSyslogServerCaCert
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#remote_syslog_server_port OperatorAccessControlOperatorControlAssignment#remote_syslog_server_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteSyslogServerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RemoteSyslogServerPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#time_assignment_from OperatorAccessControlOperatorControlAssignment#time_assignment_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeAssignmentFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeAssignmentFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#time_assignment_to OperatorAccessControlOperatorControlAssignment#time_assignment_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeAssignmentTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeAssignmentTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#timeouts OperatorAccessControlOperatorControlAssignment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.operatorAccessControlOperatorControlAssignment.OperatorAccessControlOperatorControlAssignmentTimeouts\"}", isOptional: true)]
            public oci.OperatorAccessControlOperatorControlAssignment.IOperatorAccessControlOperatorControlAssignmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OperatorAccessControlOperatorControlAssignment.IOperatorAccessControlOperatorControlAssignmentTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/operator_access_control_operator_control_assignment#validate_assignment_trigger OperatorAccessControlOperatorControlAssignment#validate_assignment_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateAssignmentTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidateAssignmentTrigger
            {
                get => GetInstanceProperty<double?>();
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
