using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainGroupConfigureDataAccess
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/iot_iot_domain_group_configure_data_access oci_iot_iot_domain_group_configure_data_access}.</summary>
    [JsiiClass(nativeType: typeof(oci.IotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccess), fullyQualifiedName: "oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccess", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessConfig\"}}]")]
    public class IotIotDomainGroupConfigureDataAccess : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/iot_iot_domain_group_configure_data_access oci_iot_iot_domain_group_configure_data_access} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotIotDomainGroupConfigureDataAccess(Constructs.Construct scope, string id, oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotDomainGroupConfigureDataAccess(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIotDomainGroupConfigureDataAccess(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IotIotDomainGroupConfigureDataAccess resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IotIotDomainGroupConfigureDataAccess to import.</param>
        /// <param name="importFromId">The id of the existing IotIotDomainGroupConfigureDataAccess that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IotIotDomainGroupConfigureDataAccess to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IotIotDomainGroupConfigureDataAccess to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/iot_iot_domain_group_configure_data_access#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IotIotDomainGroupConfigureDataAccess that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IotIotDomainGroupConfigureDataAccess to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccess), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.IotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccess))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeoutsOutputReference\"}")]
        public virtual oci.IotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbAllowListedVcnIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DbAllowListedVcnIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotDomainGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IotDomainGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dbAllowListedVcnIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbAllowListedVcnIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iotDomainGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IotDomainGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
