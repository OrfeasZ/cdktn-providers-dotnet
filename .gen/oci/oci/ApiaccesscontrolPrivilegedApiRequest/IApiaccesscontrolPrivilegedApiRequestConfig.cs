using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApiaccesscontrolPrivilegedApiRequest
{
    [JsiiInterface(nativeType: typeof(IApiaccesscontrolPrivilegedApiRequestConfig), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestConfig")]
    public interface IApiaccesscontrolPrivilegedApiRequestConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>privileged_operation_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#privileged_operation_list ApiaccesscontrolPrivilegedApiRequest#privileged_operation_list}
        /// </remarks>
        [JsiiProperty(name: "privilegedOperationList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct\"},\"kind\":\"array\"}}]}}")]
        object PrivilegedOperationList
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#reason_summary ApiaccesscontrolPrivilegedApiRequest#reason_summary}.</summary>
        [JsiiProperty(name: "reasonSummary", typeJson: "{\"primitive\":\"string\"}")]
        string ReasonSummary
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#resource_id ApiaccesscontrolPrivilegedApiRequest#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#compartment_id ApiaccesscontrolPrivilegedApiRequest#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#defined_tags ApiaccesscontrolPrivilegedApiRequest#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#duration_in_hrs ApiaccesscontrolPrivilegedApiRequest#duration_in_hrs}.</summary>
        [JsiiProperty(name: "durationInHrs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationInHrs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#freeform_tags ApiaccesscontrolPrivilegedApiRequest#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#id ApiaccesscontrolPrivilegedApiRequest#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#notification_topic_id ApiaccesscontrolPrivilegedApiRequest#notification_topic_id}.</summary>
        [JsiiProperty(name: "notificationTopicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationTopicId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#reason_detail ApiaccesscontrolPrivilegedApiRequest#reason_detail}.</summary>
        [JsiiProperty(name: "reasonDetail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReasonDetail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#severity ApiaccesscontrolPrivilegedApiRequest#severity}.</summary>
        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Severity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#sub_resource_name_list ApiaccesscontrolPrivilegedApiRequest#sub_resource_name_list}.</summary>
        [JsiiProperty(name: "subResourceNameList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubResourceNameList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#ticket_numbers ApiaccesscontrolPrivilegedApiRequest#ticket_numbers}.</summary>
        [JsiiProperty(name: "ticketNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TicketNumbers
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#timeouts ApiaccesscontrolPrivilegedApiRequest#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#time_requested_for_future_access ApiaccesscontrolPrivilegedApiRequest#time_requested_for_future_access}.</summary>
        [JsiiProperty(name: "timeRequestedForFutureAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeRequestedForFutureAccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiaccesscontrolPrivilegedApiRequestConfig), fullyQualifiedName: "oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>privileged_operation_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#privileged_operation_list ApiaccesscontrolPrivilegedApiRequest#privileged_operation_list}
            /// </remarks>
            [JsiiProperty(name: "privilegedOperationList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestPrivilegedOperationListStruct\"},\"kind\":\"array\"}}]}}")]
            public object PrivilegedOperationList
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#reason_summary ApiaccesscontrolPrivilegedApiRequest#reason_summary}.</summary>
            [JsiiProperty(name: "reasonSummary", typeJson: "{\"primitive\":\"string\"}")]
            public string ReasonSummary
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#resource_id ApiaccesscontrolPrivilegedApiRequest#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#compartment_id ApiaccesscontrolPrivilegedApiRequest#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#defined_tags ApiaccesscontrolPrivilegedApiRequest#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#duration_in_hrs ApiaccesscontrolPrivilegedApiRequest#duration_in_hrs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "durationInHrs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationInHrs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#freeform_tags ApiaccesscontrolPrivilegedApiRequest#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#id ApiaccesscontrolPrivilegedApiRequest#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#notification_topic_id ApiaccesscontrolPrivilegedApiRequest#notification_topic_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationTopicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationTopicId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#reason_detail ApiaccesscontrolPrivilegedApiRequest#reason_detail}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reasonDetail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReasonDetail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#severity ApiaccesscontrolPrivilegedApiRequest#severity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Severity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#sub_resource_name_list ApiaccesscontrolPrivilegedApiRequest#sub_resource_name_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subResourceNameList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubResourceNameList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#ticket_numbers ApiaccesscontrolPrivilegedApiRequest#ticket_numbers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ticketNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TicketNumbers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#timeouts ApiaccesscontrolPrivilegedApiRequest#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.apiaccesscontrolPrivilegedApiRequest.ApiaccesscontrolPrivilegedApiRequestTimeouts\"}", isOptional: true)]
            public oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.ApiaccesscontrolPrivilegedApiRequest.IApiaccesscontrolPrivilegedApiRequestTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apiaccesscontrol_privileged_api_request#time_requested_for_future_access ApiaccesscontrolPrivilegedApiRequest#time_requested_for_future_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeRequestedForFutureAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeRequestedForFutureAccess
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
