using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLambdawebFunctionEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/data-sources/lambdaweb_function_endpoint aws_lambdaweb_function_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpoint), fullyQualifiedName: "aws.dataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointConfig\"}}]")]
    public class DataAwsLambdawebFunctionEndpoint : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/data-sources/lambdaweb_function_endpoint aws_lambdaweb_function_endpoint} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLambdawebFunctionEndpoint(Constructs.Construct scope, string id, aws.DataAwsLambdawebFunctionEndpoint.IDataAwsLambdawebFunctionEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsLambdawebFunctionEndpoint.IDataAwsLambdawebFunctionEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdawebFunctionEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLambdawebFunctionEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsLambdawebFunctionEndpoint resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsLambdawebFunctionEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsLambdawebFunctionEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsLambdawebFunctionEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsLambdawebFunctionEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/data-sources/lambdaweb_function_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsLambdawebFunctionEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsLambdawebFunctionEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpoint))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoDeploymentMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoDeploymentMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalDomainNames", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap RegionalDomainNames
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Regions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "revisionWeights", typeJson: "{\"fqn\":\"aws.dataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointRevisionWeightsList\"}")]
        public virtual aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointRevisionWeightsList RevisionWeights
        {
            get => GetInstanceProperty<aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointRevisionWeightsList>()!;
        }

        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"aws.dataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointScalingConfigList\"}")]
        public virtual aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointScalingConfigList ScalingConfig
        {
            get => GetInstanceProperty<aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointScalingConfigList>()!;
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

        [JsiiProperty(name: "throttleConfig", typeJson: "{\"fqn\":\"aws.dataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointThrottleConfigList\"}")]
        public virtual aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointThrottleConfigList ThrottleConfig
        {
            get => GetInstanceProperty<aws.DataAwsLambdawebFunctionEndpoint.DataAwsLambdawebFunctionEndpointThrottleConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "endpointName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
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
