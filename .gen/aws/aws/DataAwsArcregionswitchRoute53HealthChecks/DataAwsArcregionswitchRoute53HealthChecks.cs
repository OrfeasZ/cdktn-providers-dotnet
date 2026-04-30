using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsArcregionswitchRoute53HealthChecks
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/arcregionswitch_route53_health_checks aws_arcregionswitch_route53_health_checks}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecks), fullyQualifiedName: "aws.dataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecks", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecksConfig\"}}]")]
    public class DataAwsArcregionswitchRoute53HealthChecks : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/arcregionswitch_route53_health_checks aws_arcregionswitch_route53_health_checks} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsArcregionswitchRoute53HealthChecks(Constructs.Construct scope, string id, aws.DataAwsArcregionswitchRoute53HealthChecks.IDataAwsArcregionswitchRoute53HealthChecksConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsArcregionswitchRoute53HealthChecks.IDataAwsArcregionswitchRoute53HealthChecksConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsArcregionswitchRoute53HealthChecks(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsArcregionswitchRoute53HealthChecks(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsArcregionswitchRoute53HealthChecks resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsArcregionswitchRoute53HealthChecks to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsArcregionswitchRoute53HealthChecks that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsArcregionswitchRoute53HealthChecks to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsArcregionswitchRoute53HealthChecks to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/arcregionswitch_route53_health_checks#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsArcregionswitchRoute53HealthChecks that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsArcregionswitchRoute53HealthChecks to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecks), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecks))!;

        [JsiiProperty(name: "healthChecks", typeJson: "{\"fqn\":\"aws.dataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecksHealthChecksList\"}")]
        public virtual aws.DataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecksHealthChecksList HealthChecks
        {
            get => GetInstanceProperty<aws.DataAwsArcregionswitchRoute53HealthChecks.DataAwsArcregionswitchRoute53HealthChecksHealthChecksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "planArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "planArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanArn
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
