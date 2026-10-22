using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.TenantmanagercontrolplaneChildTenancy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy oci_tenantmanagercontrolplane_child_tenancy}.</summary>
    [JsiiClass(nativeType: typeof(oci.TenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancy), fullyQualifiedName: "oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyConfig\"}}]")]
    public class TenantmanagercontrolplaneChildTenancy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy oci_tenantmanagercontrolplane_child_tenancy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TenantmanagercontrolplaneChildTenancy(Constructs.Construct scope, string id, oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TenantmanagercontrolplaneChildTenancy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TenantmanagercontrolplaneChildTenancy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a TenantmanagercontrolplaneChildTenancy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the TenantmanagercontrolplaneChildTenancy to import.</param>
        /// <param name="importFromId">The id of the existing TenantmanagercontrolplaneChildTenancy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the TenantmanagercontrolplaneChildTenancy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the TenantmanagercontrolplaneChildTenancy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.11.0/docs/resources/tenantmanagercontrolplane_child_tenancy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing TenantmanagercontrolplaneChildTenancy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the TenantmanagercontrolplaneChildTenancy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.TenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGovernanceStatus")]
        public virtual void ResetGovernanceStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyName")]
        public virtual void ResetPolicyName()
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
        = GetStaticProperty<string>(typeof(oci.TenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancy))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeoutsOutputReference\"}")]
        public virtual oci.TenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.TenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FeaturesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "governanceStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GovernanceStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homeRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomeRegionInput
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
        [JsiiProperty(name: "policyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenancyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.TenantmanagercontrolplaneChildTenancy.ITenantmanagercontrolplaneChildTenancyTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.tenantmanagercontrolplaneChildTenancy.TenantmanagercontrolplaneChildTenancyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "adminEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "features", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Features
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "governanceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GovernanceStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "homeRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomeRegion
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

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tenancyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
