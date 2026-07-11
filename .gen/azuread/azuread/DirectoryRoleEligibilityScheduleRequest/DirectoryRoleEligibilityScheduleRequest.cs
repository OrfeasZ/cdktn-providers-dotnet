using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DirectoryRoleEligibilityScheduleRequest
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request azuread_directory_role_eligibility_schedule_request}.</summary>
    [JsiiClass(nativeType: typeof(azuread.DirectoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequest), fullyQualifiedName: "azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequest", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestConfig\"}}]")]
    public class DirectoryRoleEligibilityScheduleRequest : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request azuread_directory_role_eligibility_schedule_request} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DirectoryRoleEligibilityScheduleRequest(Constructs.Construct scope, string id, azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryRoleEligibilityScheduleRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryRoleEligibilityScheduleRequest(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DirectoryRoleEligibilityScheduleRequest resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DirectoryRoleEligibilityScheduleRequest to import.</param>
        /// <param name="importFromId">The id of the existing DirectoryRoleEligibilityScheduleRequest that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DirectoryRoleEligibilityScheduleRequest to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DirectoryRoleEligibilityScheduleRequest to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/directory_role_eligibility_schedule_request#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DirectoryRoleEligibilityScheduleRequest that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DirectoryRoleEligibilityScheduleRequest to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuread.DirectoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequest), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts\"}}]")]
        public virtual void PutTimeouts(azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azuread.DirectoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequest))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeoutsOutputReference\"}")]
        public virtual azuread.DirectoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuread.DirectoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryScopeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryScopeIdInput
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

        [JsiiOptional]
        [JsiiProperty(name: "principalIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleDefinitionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleDefinitionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuread.DirectoryRoleEligibilityScheduleRequest.IDirectoryRoleEligibilityScheduleRequestTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuread.directoryRoleEligibilityScheduleRequest.DirectoryRoleEligibilityScheduleRequestTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "directoryScopeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryScopeId
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

        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleDefinitionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleDefinitionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
