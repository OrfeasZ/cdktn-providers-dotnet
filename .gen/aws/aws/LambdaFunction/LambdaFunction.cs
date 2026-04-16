using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function aws_lambda_function}.</summary>
    [JsiiClass(nativeType: typeof(aws.LambdaFunction.LambdaFunction), fullyQualifiedName: "aws.lambdaFunction.LambdaFunction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionConfig\"}}]")]
    public class LambdaFunction : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function aws_lambda_function} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaFunction(Constructs.Construct scope, string id, aws.LambdaFunction.ILambdaFunctionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LambdaFunction.ILambdaFunctionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunction(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LambdaFunction resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LambdaFunction to import.</param>
        /// <param name="importFromId">The id of the existing LambdaFunction that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LambdaFunction to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LambdaFunction to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_function#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LambdaFunction that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LambdaFunction to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.LambdaFunction.LambdaFunction), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCapacityProviderConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfig\"}}]")]
        public virtual void PutCapacityProviderConfig(aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeadLetterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionDeadLetterConfig\"}}]")]
        public virtual void PutDeadLetterConfig(aws.LambdaFunction.ILambdaFunctionDeadLetterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionDeadLetterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDurableConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionDurableConfig\"}}]")]
        public virtual void PutDurableConfig(aws.LambdaFunction.ILambdaFunctionDurableConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionDurableConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionEnvironment\"}}]")]
        public virtual void PutEnvironment(aws.LambdaFunction.ILambdaFunctionEnvironment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionEnvironment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEphemeralStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionEphemeralStorage\"}}]")]
        public virtual void PutEphemeralStorage(aws.LambdaFunction.ILambdaFunctionEphemeralStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionEphemeralStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystemConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionFileSystemConfig\"}}]")]
        public virtual void PutFileSystemConfig(aws.LambdaFunction.ILambdaFunctionFileSystemConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionFileSystemConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionImageConfig\"}}]")]
        public virtual void PutImageConfig(aws.LambdaFunction.ILambdaFunctionImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoggingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionLoggingConfig\"}}]")]
        public virtual void PutLoggingConfig(aws.LambdaFunction.ILambdaFunctionLoggingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionLoggingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapStart", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionSnapStart\"}}]")]
        public virtual void PutSnapStart(aws.LambdaFunction.ILambdaFunctionSnapStart @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionSnapStart)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTenancyConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTenancyConfig\"}}]")]
        public virtual void PutTenancyConfig(aws.LambdaFunction.ILambdaFunctionTenancyConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionTenancyConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LambdaFunction.ILambdaFunctionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTracingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTracingConfig\"}}]")]
        public virtual void PutTracingConfig(aws.LambdaFunction.ILambdaFunctionTracingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionTracingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaFunction.LambdaFunctionVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.LambdaFunction.ILambdaFunctionVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaFunction.ILambdaFunctionVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArchitectures")]
        public virtual void ResetArchitectures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityProviderConfig")]
        public virtual void ResetCapacityProviderConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeSha256")]
        public virtual void ResetCodeSha256()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeSigningConfigArn")]
        public virtual void ResetCodeSigningConfigArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDurableConfig")]
        public virtual void ResetDurableConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralStorage")]
        public virtual void ResetEphemeralStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilename")]
        public virtual void ResetFilename()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemConfig")]
        public virtual void ResetFileSystemConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHandler")]
        public virtual void ResetHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageConfig")]
        public virtual void ResetImageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageUri")]
        public virtual void ResetImageUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLayers")]
        public virtual void ResetLayers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingConfig")]
        public virtual void ResetLoggingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemorySize")]
        public virtual void ResetMemorySize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageType")]
        public virtual void ResetPackageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublish")]
        public virtual void ResetPublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublishTo")]
        public virtual void ResetPublishTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplacementSecurityGroupIds")]
        public virtual void ResetReplacementSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplaceSecurityGroupsOnDestroy")]
        public virtual void ResetReplaceSecurityGroupsOnDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReservedConcurrentExecutions")]
        public virtual void ResetReservedConcurrentExecutions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntime")]
        public virtual void ResetRuntime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Bucket")]
        public virtual void ResetS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Key")]
        public virtual void ResetS3Key()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3ObjectVersion")]
        public virtual void ResetS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipDestroy")]
        public virtual void ResetSkipDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapStart")]
        public virtual void ResetSnapStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceCodeHash")]
        public virtual void ResetSourceCodeHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceKmsKeyArn")]
        public virtual void ResetSourceKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenancyConfig")]
        public virtual void ResetTenancyConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTracingConfig")]
        public virtual void ResetTracingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.LambdaFunction.LambdaFunction))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityProviderConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionCapacityProviderConfigOutputReference CapacityProviderConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionCapacityProviderConfigOutputReference>()!;
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionDeadLetterConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionDeadLetterConfigOutputReference DeadLetterConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionDeadLetterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "durableConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionDurableConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionDurableConfigOutputReference DurableConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionDurableConfigOutputReference>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionEnvironmentOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionEnvironmentOutputReference Environment
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionEnvironmentOutputReference>()!;
        }

        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionEphemeralStorageOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionEphemeralStorageOutputReference EphemeralStorage
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionEphemeralStorageOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionFileSystemConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionFileSystemConfigOutputReference FileSystemConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionFileSystemConfigOutputReference>()!;
        }

        [JsiiProperty(name: "imageConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionImageConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionImageConfigOutputReference ImageConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionImageConfigOutputReference>()!;
        }

        [JsiiProperty(name: "invokeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionLoggingConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionLoggingConfigOutputReference LoggingConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionLoggingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "qualifiedArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualifiedArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "qualifiedInvokeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualifiedInvokeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseStreamingInvokeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseStreamingInvokeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingJobArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningJobArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingProfileVersionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningProfileVersionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapStart", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionSnapStartOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionSnapStartOutputReference SnapStart
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionSnapStartOutputReference>()!;
        }

        [JsiiProperty(name: "sourceCodeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SourceCodeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tenancyConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTenancyConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionTenancyConfigOutputReference TenancyConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionTenancyConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTimeoutsOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "tracingConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTracingConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionTracingConfigOutputReference TracingConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionTracingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionVpcConfigOutputReference\"}")]
        public virtual aws.LambdaFunction.LambdaFunctionVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.LambdaFunction.LambdaFunctionVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "architecturesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ArchitecturesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionCapacityProviderConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig? CapacityProviderConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionCapacityProviderConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeSha256Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeSha256Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeSigningConfigArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeSigningConfigArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionDeadLetterConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionDeadLetterConfig? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionDeadLetterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durableConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionDurableConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionDurableConfig? DurableConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionDurableConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionEnvironment\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionEnvironment? EnvironmentInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionEnvironment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralStorageInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionEphemeralStorage\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionEphemeralStorage? EphemeralStorageInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionEphemeralStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filenameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FilenameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionFileSystemConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionFileSystemConfig? FileSystemConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionFileSystemConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HandlerInput
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
        [JsiiProperty(name: "imageConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionImageConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionImageConfig? ImageConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionImageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "layersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LayersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionLoggingConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionLoggingConfig? LoggingConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionLoggingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memorySizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemorySizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublishInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublishToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replacementSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ReplacementSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceSecurityGroupsOnDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReplaceSecurityGroupsOnDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedConcurrentExecutionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReservedConcurrentExecutionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SkipDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapStartInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionSnapStart\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionSnapStart? SnapStartInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionSnapStart?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCodeHashInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceKmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceKmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTenancyConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionTenancyConfig? TenancyConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionTenancyConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tracingConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionTracingConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionTracingConfig? TracingConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionTracingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.lambdaFunction.LambdaFunctionVpcConfig\"}", isOptional: true)]
        public virtual aws.LambdaFunction.ILambdaFunctionVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.LambdaFunction.ILambdaFunctionVpcConfig?>();
        }

        [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Architectures
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codeSha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodeSha256
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codeSigningConfigArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CodeSigningConfigArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Filename
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

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
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

        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Layers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Publish
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "publishTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublishTo
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

        [JsiiProperty(name: "replacementSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReplacementSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replaceSecurityGroupsOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReplaceSecurityGroupsOnDestroy
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedConcurrentExecutions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Runtime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skipDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SkipDestroy
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeHash
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceKmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
