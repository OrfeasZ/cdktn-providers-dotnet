using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BastionSession
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session oci_bastion_session}.</summary>
    [JsiiClass(nativeType: typeof(oci.BastionSession.BastionSession), fullyQualifiedName: "oci.bastionSession.BastionSession", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.bastionSession.BastionSessionConfig\"}}]")]
    public class BastionSession : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session oci_bastion_session} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BastionSession(Constructs.Construct scope, string id, oci.BastionSession.IBastionSessionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.BastionSession.IBastionSessionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BastionSession(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BastionSession(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BastionSession resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BastionSession to import.</param>
        /// <param name="importFromId">The id of the existing BastionSession that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BastionSession to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BastionSession to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BastionSession that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BastionSession to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.BastionSession.BastionSession), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putKeyDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bastionSession.BastionSessionKeyDetails\"}}]")]
        public virtual void PutKeyDetails(oci.BastionSession.IBastionSessionKeyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BastionSession.IBastionSessionKeyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetResourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bastionSession.BastionSessionTargetResourceDetails\"}}]")]
        public virtual void PutTargetResourceDetails(oci.BastionSession.IBastionSessionTargetResourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BastionSession.IBastionSessionTargetResourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bastionSession.BastionSessionTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.BastionSession.IBastionSessionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BastionSession.IBastionSessionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyType")]
        public virtual void ResetKeyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionTtlInSeconds")]
        public virtual void ResetSessionTtlInSeconds()
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
        = GetStaticProperty<string>(typeof(oci.BastionSession.BastionSession))!;

        [JsiiProperty(name: "bastionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bastionPublicHostKeyInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionPublicHostKeyInfo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bastionUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyDetails", typeJson: "{\"fqn\":\"oci.bastionSession.BastionSessionKeyDetailsOutputReference\"}")]
        public virtual oci.BastionSession.BastionSessionKeyDetailsOutputReference KeyDetails
        {
            get => GetInstanceProperty<oci.BastionSession.BastionSessionKeyDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sshMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SshMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceDetails", typeJson: "{\"fqn\":\"oci.bastionSession.BastionSessionTargetResourceDetailsOutputReference\"}")]
        public virtual oci.BastionSession.BastionSessionTargetResourceDetailsOutputReference TargetResourceDetails
        {
            get => GetInstanceProperty<oci.BastionSession.BastionSessionTargetResourceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bastionSession.BastionSessionTimeoutsOutputReference\"}")]
        public virtual oci.BastionSession.BastionSessionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.BastionSession.BastionSessionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bastionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BastionIdInput
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyDetailsInput", typeJson: "{\"fqn\":\"oci.bastionSession.BastionSessionKeyDetails\"}", isOptional: true)]
        public virtual oci.BastionSession.IBastionSessionKeyDetails? KeyDetailsInput
        {
            get => GetInstanceProperty<oci.BastionSession.IBastionSessionKeyDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTtlInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SessionTtlInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceDetailsInput", typeJson: "{\"fqn\":\"oci.bastionSession.BastionSessionTargetResourceDetails\"}", isOptional: true)]
        public virtual oci.BastionSession.IBastionSessionTargetResourceDetails? TargetResourceDetailsInput
        {
            get => GetInstanceProperty<oci.BastionSession.IBastionSessionTargetResourceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.bastionSession.BastionSessionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bastionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionId
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionTtlInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTtlInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
