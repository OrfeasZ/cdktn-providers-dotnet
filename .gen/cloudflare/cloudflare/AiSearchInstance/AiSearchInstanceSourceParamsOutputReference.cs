using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsOutputReference), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiSearchInstanceSourceParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiSearchInstanceSourceParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiSearchInstanceSourceParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiSearchInstanceSourceParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWebCrawler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler\"}}]")]
        public virtual void PutWebCrawler(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludeItems")]
        public virtual void ResetExcludeItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeItems")]
        public virtual void ResetIncludeItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetR2Jurisdiction")]
        public virtual void ResetR2Jurisdiction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebCrawler")]
        public virtual void ResetWebCrawler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "webCrawler", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerOutputReference WebCrawler
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeItemsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludeItemsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeItemsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IncludeItemsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "r2JurisdictionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? R2JurisdictionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler\"}]}}", isOptional: true)]
        public virtual object? WebCrawlerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "excludeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludeItems
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludeItems
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "r2Jurisdiction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string R2Jurisdiction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParams\"}]}}", isOptional: true)]
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
                        case cloudflare.AiSearchInstance.IAiSearchInstanceSourceParams cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParams).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
