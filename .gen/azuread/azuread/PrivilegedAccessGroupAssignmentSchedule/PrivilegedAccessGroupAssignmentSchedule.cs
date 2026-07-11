using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.PrivilegedAccessGroupAssignmentSchedule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule azuread_privileged_access_group_assignment_schedule}.</summary>
    [JsiiClass(nativeType: typeof(azuread.PrivilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentSchedule), fullyQualifiedName: "azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentSchedule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleConfig\"}}]")]
    public class PrivilegedAccessGroupAssignmentSchedule : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule azuread_privileged_access_group_assignment_schedule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PrivilegedAccessGroupAssignmentSchedule(Constructs.Construct scope, string id, azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrivilegedAccessGroupAssignmentSchedule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PrivilegedAccessGroupAssignmentSchedule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PrivilegedAccessGroupAssignmentSchedule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PrivilegedAccessGroupAssignmentSchedule to import.</param>
        /// <param name="importFromId">The id of the existing PrivilegedAccessGroupAssignmentSchedule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PrivilegedAccessGroupAssignmentSchedule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PrivilegedAccessGroupAssignmentSchedule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/privileged_access_group_assignment_schedule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PrivilegedAccessGroupAssignmentSchedule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PrivilegedAccessGroupAssignmentSchedule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.PrivilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentSchedule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDuration")]
        public virtual void ResetDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpirationDate")]
        public virtual void ResetExpirationDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJustification")]
        public virtual void ResetJustification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermanentAssignment")]
        public virtual void ResetPermanentAssignment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartDate")]
        public virtual void ResetStartDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTicketNumber")]
        public virtual void ResetTicketNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTicketSystem")]
        public virtual void ResetTicketSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azuread.PrivilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentSchedule))!;

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeoutsOutputReference\"}")]
        public virtual azuread.PrivilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.PrivilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssignmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpirationDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "justificationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JustificationInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permanentAssignmentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PermanentAssignmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ticketNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TicketNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ticketSystemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TicketSystemInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.PrivilegedAccessGroupAssignmentSchedule.IPrivilegedAccessGroupAssignmentScheduleTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.privilegedAccessGroupAssignmentSchedule.PrivilegedAccessGroupAssignmentScheduleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "assignmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssignmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Duration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expirationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "permanentAssignment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PermanentAssignment
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ticketNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TicketNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ticketSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TicketSystem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
