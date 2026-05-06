using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementFleetCredential
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential oci_fleet_apps_management_fleet_credential}.</summary>
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredential), fullyQualifiedName: "oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredential", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialConfig\"}}]")]
    public class FleetAppsManagementFleetCredential : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential oci_fleet_apps_management_fleet_credential} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FleetAppsManagementFleetCredential(Constructs.Construct scope, string id, oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleetCredential(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementFleetCredential(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a FleetAppsManagementFleetCredential resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FleetAppsManagementFleetCredential to import.</param>
        /// <param name="importFromId">The id of the existing FleetAppsManagementFleetCredential that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FleetAppsManagementFleetCredential to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FleetAppsManagementFleetCredential to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_fleet_credential#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FleetAppsManagementFleetCredential that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FleetAppsManagementFleetCredential to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredential), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEntitySpecifics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecifics\"}}]")]
        public virtual void PutEntitySpecifics(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPassword\"}}]")]
        public virtual void PutPassword(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUser\"}}]")]
        public virtual void PutUser(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredential))!;

        [JsiiProperty(name: "entitySpecifics", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecificsOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecificsOutputReference EntitySpecifics
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecificsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPasswordOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPasswordOutputReference Password
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPasswordOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeoutsOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUserOutputReference\"}")]
        public virtual oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUserOutputReference User
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entitySpecificsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialEntitySpecifics\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics? EntitySpecificsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialEntitySpecifics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetIdInput
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
        [JsiiProperty(name: "passwordInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialPassword\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword? PasswordInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialPassword?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementFleetCredential.FleetAppsManagementFleetCredentialUser\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser? UserInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementFleetCredential.IFleetAppsManagementFleetCredentialUser?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
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
    }
}
