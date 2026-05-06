using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiClass(nativeType: typeof(cloudflare.PipelineSink.PipelineSinkConfigAOutputReference), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipelineSinkConfigAOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipelineSinkConfigAOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipelineSinkConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipelineSinkConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigCredentials\"}}]")]
        public virtual void PutCredentials(cloudflare.PipelineSink.IPipelineSinkConfigCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PipelineSink.IPipelineSinkConfigCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileNaming", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigFileNaming\"}}]")]
        public virtual void PutFileNaming(cloudflare.PipelineSink.IPipelineSinkConfigFileNaming @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PipelineSink.IPipelineSinkConfigFileNaming)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPartitioning", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigPartitioning\"}}]")]
        public virtual void PutPartitioning(cloudflare.PipelineSink.IPipelineSinkConfigPartitioning @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PipelineSink.IPipelineSinkConfigPartitioning)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy\"}}]")]
        public virtual void PutRollingPolicy(cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PipelineSink.IPipelineSinkConfigRollingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileNaming")]
        public virtual void ResetFileNaming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJurisdiction")]
        public virtual void ResetJurisdiction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitioning")]
        public virtual void ResetPartitioning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollingPolicy")]
        public virtual void ResetRollingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableName")]
        public virtual void ResetTableName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToken")]
        public virtual void ResetToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigCredentialsOutputReference\"}")]
        public virtual cloudflare.PipelineSink.PipelineSinkConfigCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<cloudflare.PipelineSink.PipelineSinkConfigCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "fileNaming", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigFileNamingOutputReference\"}")]
        public virtual cloudflare.PipelineSink.PipelineSinkConfigFileNamingOutputReference FileNaming
        {
            get => GetInstanceProperty<cloudflare.PipelineSink.PipelineSinkConfigFileNamingOutputReference>()!;
        }

        [JsiiProperty(name: "partitioning", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigPartitioningOutputReference\"}")]
        public virtual cloudflare.PipelineSink.PipelineSinkConfigPartitioningOutputReference Partitioning
        {
            get => GetInstanceProperty<cloudflare.PipelineSink.PipelineSinkConfigPartitioningOutputReference>()!;
        }

        [JsiiProperty(name: "rollingPolicy", typeJson: "{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigRollingPolicyOutputReference\"}")]
        public virtual cloudflare.PipelineSink.PipelineSinkConfigRollingPolicyOutputReference RollingPolicy
        {
            get => GetInstanceProperty<cloudflare.PipelineSink.PipelineSinkConfigRollingPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigCredentials\"}]}}", isOptional: true)]
        public virtual object? CredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileNamingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigFileNaming\"}]}}", isOptional: true)]
        public virtual object? FileNamingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jurisdictionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JurisdictionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitioningInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigPartitioning\"}]}}", isOptional: true)]
        public virtual object? PartitioningInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollingPolicyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigRollingPolicy\"}]}}", isOptional: true)]
        public virtual object? RollingPolicyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Jurisdiction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Token
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pipelineSink.PipelineSinkConfigA\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.PipelineSink.IPipelineSinkConfigA cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.PipelineSink.IPipelineSinkConfigA).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
