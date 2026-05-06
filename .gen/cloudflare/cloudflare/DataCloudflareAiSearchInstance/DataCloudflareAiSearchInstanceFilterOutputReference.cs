using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilterOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstanceFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstanceFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstanceFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstanceFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderBy")]
        public virtual void ResetOrderBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderByDirection")]
        public virtual void ResetOrderByDirection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearch")]
        public virtual void ResetSearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderByDirectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrderByDirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderByInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrderByInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orderBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderBy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orderByDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderByDirection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Search
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstanceFilter\"}]}}", isOptional: true)]
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
                        case cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceFilter cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstanceFilter).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
