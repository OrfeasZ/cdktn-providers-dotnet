using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiClass(nativeType: typeof(cloudflare.WorkerVersion.WorkerVersionAssetsOutputReference), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionAssetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerVersionAssetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkerVersionAssetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkerVersionAssetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerVersionAssetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssetsConfig\"}}]")]
        public virtual void PutConfig(cloudflare.WorkerVersion.IWorkerVersionAssetsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionAssetsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfig")]
        public virtual void ResetConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDirectory")]
        public virtual void ResetDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwt")]
        public virtual void ResetJwt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "assetManifestSha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssetManifestSha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssetsConfigOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionAssetsConfigOutputReference Config
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionAssetsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssetsConfig\"}]}}", isOptional: true)]
        public virtual object? ConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwtInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Directory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Jwt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssets\"}]}}", isOptional: true)]
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
                        case cloudflare.WorkerVersion.IWorkerVersionAssets cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionAssets).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
