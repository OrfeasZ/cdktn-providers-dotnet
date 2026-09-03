using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainConfigureDataAccess
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_domain_configure_data_access oci_iot_iot_domain_configure_data_access}.</summary>
    [JsiiClass(nativeType: typeof(oci.IotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccess), fullyQualifiedName: "oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccess", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessConfig\"}}]")]
    public class IotIotDomainConfigureDataAccess : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_domain_configure_data_access oci_iot_iot_domain_configure_data_access} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotIotDomainConfigureDataAccess(Constructs.Construct scope, string id, oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotDomainConfigureDataAccess(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotDomainConfigureDataAccess(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IotIotDomainConfigureDataAccess resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotIotDomainConfigureDataAccess to import.</param>
        /// <param name="importFromId">The id of the existing IotIotDomainConfigureDataAccess that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotIotDomainConfigureDataAccess to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotIotDomainConfigureDataAccess to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_domain_configure_data_access#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotIotDomainConfigureDataAccess that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotIotDomainConfigureDataAccess to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccess), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDbAllowedIdentityDomainHost")]
        public virtual void ResetDbAllowedIdentityDomainHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbAllowListedIdentityGroupNames")]
        public virtual void ResetDbAllowListedIdentityGroupNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbWorkspaceAdminInitialPassword")]
        public virtual void ResetDbWorkspaceAdminInitialPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.IotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccess))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeoutsOutputReference\"}")]
        public virtual oci.IotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbAllowedIdentityDomainHostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbAllowedIdentityDomainHostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbAllowListedIdentityGroupNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DbAllowListedIdentityGroupNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbWorkspaceAdminInitialPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbWorkspaceAdminInitialPasswordInput
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
        [JsiiProperty(name: "iotDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IotDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.IotIotDomainConfigureDataAccess.IIotIotDomainConfigureDataAccessTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.iotIotDomainConfigureDataAccess.IotIotDomainConfigureDataAccessTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbAllowedIdentityDomainHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbAllowedIdentityDomainHost
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbAllowListedIdentityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbAllowListedIdentityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbWorkspaceAdminInitialPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkspaceAdminInitialPassword
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

        [JsiiProperty(name: "iotDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IotDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
