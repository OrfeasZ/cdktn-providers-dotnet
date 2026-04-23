using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/guardduty_organization_configuration aws_guardduty_organization_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationConfig\"}}]")]
    public class GuarddutyOrganizationConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/guardduty_organization_configuration aws_guardduty_organization_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GuarddutyOrganizationConfiguration(Constructs.Construct scope, string id, aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyOrganizationConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyOrganizationConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a GuarddutyOrganizationConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GuarddutyOrganizationConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing GuarddutyOrganizationConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GuarddutyOrganizationConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GuarddutyOrganizationConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/guardduty_organization_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GuarddutyOrganizationConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GuarddutyOrganizationConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDatasources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources\"}}]")]
        public virtual void PutDatasources(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDatasources")]
        public virtual void ResetDatasources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfiguration))!;

        [JsiiProperty(name: "datasources", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesOutputReference\"}")]
        public virtual aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesOutputReference Datasources
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoEnableOrganizationMembersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoEnableOrganizationMembersInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasourcesInput", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources\"}", isOptional: true)]
        public virtual aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources? DatasourcesInput
        {
            get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DetectorIdInput
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoEnableOrganizationMembers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoEnableOrganizationMembers
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorId
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
