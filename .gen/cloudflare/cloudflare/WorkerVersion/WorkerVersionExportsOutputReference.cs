using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiClass(nativeType: typeof(cloudflare.WorkerVersion.WorkerVersionExportsOutputReference), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionExportsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the key of this item in the map.\"},\"name\":\"complexObjectKey\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerVersionExportsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectKey">the key of this item in the map.</param>
        public WorkerVersionExportsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, string complexObjectKey): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectKey))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, string complexObjectKey)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectKey});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerVersionExportsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerVersionExportsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCache", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsCache\"}}]")]
        public virtual void PutCache(cloudflare.WorkerVersion.IWorkerVersionExportsCache @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.WorkerVersion.IWorkerVersionExportsCache)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenamedTo")]
        public virtual void ResetRenamedTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorage")]
        public virtual void ResetStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferFrom")]
        public virtual void ResetTransferFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferredTo")]
        public virtual void ResetTransferredTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsCacheOutputReference\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionExportsCacheOutputReference Cache
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionExportsCacheOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.WorkerVersion.IWorkerVersionExportsCache" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsCache\"}]}}", isOptional: true)]
        public virtual object? CacheInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renamedToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RenamedToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transferFromInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransferFromInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transferredToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransferredToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "renamedTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenamedTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Storage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transferFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferFrom
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transferredTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferredTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="cloudflare.WorkerVersion.IWorkerVersionExports" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExports\"}]}}", isOptional: true)]
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
                        case cloudflare.WorkerVersion.IWorkerVersionExports cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionExports).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
