using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayInstanceSecurityGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/instance_security_group scaleway_instance_security_group}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroup), fullyQualifiedName: "scaleway.dataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupConfig\"}}]")]
    public class DataScalewayInstanceSecurityGroup : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/instance_security_group scaleway_instance_security_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayInstanceSecurityGroup(Constructs.Construct scope, string id, scaleway.DataScalewayInstanceSecurityGroup.IDataScalewayInstanceSecurityGroupConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayInstanceSecurityGroup.IDataScalewayInstanceSecurityGroupConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceSecurityGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayInstanceSecurityGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayInstanceSecurityGroup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayInstanceSecurityGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayInstanceSecurityGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayInstanceSecurityGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayInstanceSecurityGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/instance_security_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayInstanceSecurityGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayInstanceSecurityGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupId")]
        public virtual void ResetSecurityGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroup))!;

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableDefaultSecurity", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableDefaultSecurity
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "externalRules", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExternalRules
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "inboundDefaultPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InboundDefaultPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inboundRule", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupInboundRuleList\"}")]
        public virtual scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupInboundRuleList InboundRule
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupInboundRuleList>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundDefaultPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundDefaultPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundRule", typeJson: "{\"fqn\":\"scaleway.dataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupOutboundRuleList\"}")]
        public virtual scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupOutboundRuleList OutboundRule
        {
            get => GetInstanceProperty<scaleway.DataScalewayInstanceSecurityGroup.DataScalewayInstanceSecurityGroupOutboundRuleList>()!;
        }

        [JsiiProperty(name: "stateful", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Stateful
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
