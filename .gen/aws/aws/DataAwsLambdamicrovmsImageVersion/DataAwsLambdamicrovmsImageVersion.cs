using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLambdamicrovmsImageVersion
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/data-sources/lambdamicrovms_image_version aws_lambdamicrovms_image_version}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersion), fullyQualifiedName: "aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionConfig\"}}]")]
    public class DataAwsLambdamicrovmsImageVersion : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/data-sources/lambdamicrovms_image_version aws_lambdamicrovms_image_version} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLambdamicrovmsImageVersion(Constructs.Construct scope, string id, aws.DataAwsLambdamicrovmsImageVersion.IDataAwsLambdamicrovmsImageVersionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsLambdamicrovmsImageVersion.IDataAwsLambdamicrovmsImageVersionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdamicrovmsImageVersion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdamicrovmsImageVersion(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsLambdamicrovmsImageVersion resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsLambdamicrovmsImageVersion to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsLambdamicrovmsImageVersion that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsLambdamicrovmsImageVersion to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsLambdamicrovmsImageVersion to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/data-sources/lambdamicrovms_image_version#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsLambdamicrovmsImageVersion that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsLambdamicrovmsImageVersion to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersion), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersion))!;

        [JsiiProperty(name: "additionalOsCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalOsCapabilities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "baseImageArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseImageArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "baseImageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseImageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "codeArtifact", typeJson: "{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionCodeArtifactList\"}")]
        public virtual aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionCodeArtifactList CodeArtifact
        {
            get => GetInstanceProperty<aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionCodeArtifactList>()!;
        }

        [JsiiProperty(name: "cpuConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionCpuConfigurationList\"}")]
        public virtual aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionCpuConfigurationList CpuConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionCpuConfigurationList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "egressNetworkConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EgressNetworkConnectors
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap EnvironmentVariables
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hooks", typeJson: "{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionHooksList\"}")]
        public virtual aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionHooksList Hooks
        {
            get => GetInstanceProperty<aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionHooksList>()!;
        }

        [JsiiProperty(name: "imageArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionLoggingList\"}")]
        public virtual aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionLoggingList Logging
        {
            get => GetInstanceProperty<aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionLoggingList>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"aws.dataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionResourcesList\"}")]
        public virtual aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionResourcesList Resources
        {
            get => GetInstanceProperty<aws.DataAwsLambdamicrovmsImageVersion.DataAwsLambdamicrovmsImageVersionResourcesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "imageIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageVersion
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
