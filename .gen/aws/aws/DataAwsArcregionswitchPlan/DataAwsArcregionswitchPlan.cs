using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsArcregionswitchPlan
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/arcregionswitch_plan aws_arcregionswitch_plan}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsArcregionswitchPlan.DataAwsArcregionswitchPlan), fullyQualifiedName: "aws.dataAwsArcregionswitchPlan.DataAwsArcregionswitchPlan", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsArcregionswitchPlan.DataAwsArcregionswitchPlanConfig\"}}]")]
    public class DataAwsArcregionswitchPlan : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/arcregionswitch_plan aws_arcregionswitch_plan} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsArcregionswitchPlan(Constructs.Construct scope, string id, aws.DataAwsArcregionswitchPlan.IDataAwsArcregionswitchPlanConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsArcregionswitchPlan.IDataAwsArcregionswitchPlanConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsArcregionswitchPlan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsArcregionswitchPlan(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsArcregionswitchPlan resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsArcregionswitchPlan to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsArcregionswitchPlan that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsArcregionswitchPlan to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsArcregionswitchPlan to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/arcregionswitch_plan#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsArcregionswitchPlan that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsArcregionswitchPlan to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsArcregionswitchPlan.DataAwsArcregionswitchPlan), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsArcregionswitchPlan.DataAwsArcregionswitchPlan))!;

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoveryApproach", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecoveryApproach
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoveryTimeObjectiveMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryTimeObjectiveMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Regions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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
