using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabaseSecretsManagerIntegration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database_secrets_manager_integration aws_odb_autonomous_database_secrets_manager_integration}.</summary>
    [JsiiClass(nativeType: typeof(aws.OdbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegration), fullyQualifiedName: "aws.odbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.odbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegrationConfig\"}}]")]
    public class OdbAutonomousDatabaseSecretsManagerIntegration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database_secrets_manager_integration aws_odb_autonomous_database_secrets_manager_integration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OdbAutonomousDatabaseSecretsManagerIntegration(Constructs.Construct scope, string id, aws.OdbAutonomousDatabaseSecretsManagerIntegration.IOdbAutonomousDatabaseSecretsManagerIntegrationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OdbAutonomousDatabaseSecretsManagerIntegration.IOdbAutonomousDatabaseSecretsManagerIntegrationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OdbAutonomousDatabaseSecretsManagerIntegration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OdbAutonomousDatabaseSecretsManagerIntegration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OdbAutonomousDatabaseSecretsManagerIntegration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OdbAutonomousDatabaseSecretsManagerIntegration to import.</param>
        /// <param name="importFromId">The id of the existing OdbAutonomousDatabaseSecretsManagerIntegration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OdbAutonomousDatabaseSecretsManagerIntegration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OdbAutonomousDatabaseSecretsManagerIntegration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database_secrets_manager_integration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OdbAutonomousDatabaseSecretsManagerIntegration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OdbAutonomousDatabaseSecretsManagerIntegration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.OdbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.odbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegrationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.OdbAutonomousDatabaseSecretsManagerIntegration.IOdbAutonomousDatabaseSecretsManagerIntegrationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OdbAutonomousDatabaseSecretsManagerIntegration.IOdbAutonomousDatabaseSecretsManagerIntegrationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.OdbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegration))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegrationTimeoutsOutputReference\"}")]
        public virtual aws.OdbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegrationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.OdbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegrationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.OdbAutonomousDatabaseSecretsManagerIntegration.IOdbAutonomousDatabaseSecretsManagerIntegrationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.odbAutonomousDatabaseSecretsManagerIntegration.OdbAutonomousDatabaseSecretsManagerIntegrationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
