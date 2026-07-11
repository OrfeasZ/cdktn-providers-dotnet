using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.PrivilegedAccessGroupAssignmentSchedule
{
    [JsiiInterface(nativeType: typeof(IPrivilegedAccessGroupAssignmentScheduleConfig), fullyQualifiedName: "azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleConfig")]
    public interface IPrivilegedAccessGroupAssignmentScheduleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the assignment to the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#assignment_type PrivilegedAccessGroupAssignmentSchedule#assignment_type}
        /// </remarks>
        [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}")]
        string AssignmentType
        {
            get;
        }

        /// <summary>The ID of the Group representing the scope of the assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#group_id PrivilegedAccessGroupAssignmentSchedule#group_id}
        /// </remarks>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>The ID of the Principal assigned to the schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#principal_id PrivilegedAccessGroupAssignmentSchedule#principal_id}
        /// </remarks>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        /// <summary>The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#duration PrivilegedAccessGroupAssignmentSchedule#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#expiration_date PrivilegedAccessGroupAssignmentSchedule#expiration_date}
        /// </remarks>
        [JsiiProperty(name: "expirationDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpirationDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#id PrivilegedAccessGroupAssignmentSchedule#id}.</summary>
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

        /// <summary>The justification for the assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#justification PrivilegedAccessGroupAssignmentSchedule#justification}
        /// </remarks>
        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Justification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Is the assignment permanent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#permanent_assignment PrivilegedAccessGroupAssignmentSchedule#permanent_assignment}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "permanentAssignment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PermanentAssignment
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#start_date PrivilegedAccessGroupAssignmentSchedule#start_date}
        /// </remarks>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ticket number authorising the assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#ticket_number PrivilegedAccessGroupAssignmentSchedule#ticket_number}
        /// </remarks>
        [JsiiProperty(name: "ticketNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TicketNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ticket system authorising the assignment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#ticket_system PrivilegedAccessGroupAssignmentSchedule#ticket_system}
        /// </remarks>
        [JsiiProperty(name: "ticketSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TicketSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#timeouts PrivilegedAccessGroupAssignmentSchedule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivilegedAccessGroupAssignmentScheduleConfig), fullyQualifiedName: "azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the assignment to the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#assignment_type PrivilegedAccessGroupAssignmentSchedule#assignment_type}
            /// </remarks>
            [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}")]
            public string AssignmentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the Group representing the scope of the assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#group_id PrivilegedAccessGroupAssignmentSchedule#group_id}
            /// </remarks>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the Principal assigned to the schedule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#principal_id PrivilegedAccessGroupAssignmentSchedule#principal_id}
            /// </remarks>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#duration PrivilegedAccessGroupAssignmentSchedule#duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#expiration_date PrivilegedAccessGroupAssignmentSchedule#expiration_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expirationDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpirationDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#id PrivilegedAccessGroupAssignmentSchedule#id}.</summary>
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

            /// <summary>The justification for the assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#justification PrivilegedAccessGroupAssignmentSchedule#justification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Justification
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Is the assignment permanent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#permanent_assignment PrivilegedAccessGroupAssignmentSchedule#permanent_assignment}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permanentAssignment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PermanentAssignment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#start_date PrivilegedAccessGroupAssignmentSchedule#start_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ticket number authorising the assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#ticket_number PrivilegedAccessGroupAssignmentSchedule#ticket_number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ticketNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TicketNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ticket system authorising the assignment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#ticket_system PrivilegedAccessGroupAssignmentSchedule#ticket_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ticketSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TicketSystem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#timeouts PrivilegedAccessGroupAssignmentSchedule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeouts\"}", isOptional: true)]
            public azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
