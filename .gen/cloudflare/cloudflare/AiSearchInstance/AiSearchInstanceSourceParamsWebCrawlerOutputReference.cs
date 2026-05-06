using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerOutputReference), fullyQualifiedName: "cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiSearchInstanceSourceParamsWebCrawlerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiSearchInstanceSourceParamsWebCrawlerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiSearchInstanceSourceParamsWebCrawlerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiSearchInstanceSourceParamsWebCrawlerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCrawlOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptions\"}}]")]
        public virtual void PutCrawlOptions(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerCrawlOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerCrawlOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParseOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}}]")]
        public virtual void PutParseOptions(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerParseOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStoreOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}}]")]
        public virtual void PutStoreOptions(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawlerStoreOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCrawlOptions")]
        public virtual void ResetCrawlOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParseOptions")]
        public virtual void ResetParseOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParseType")]
        public virtual void ResetParseType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStoreOptions")]
        public virtual void ResetStoreOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "crawlOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptionsOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptionsOutputReference CrawlOptions
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "parseOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference ParseOptions
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "storeOptions", typeJson: "{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptionsOutputReference\"}")]
        public virtual cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptionsOutputReference StoreOptions
        {
            get => GetInstanceProperty<cloudflare.AiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crawlOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerCrawlOptions\"}]}}", isOptional: true)]
        public virtual object? CrawlOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parseOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerParseOptions\"}]}}", isOptional: true)]
        public virtual object? ParseOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parseTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParseTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storeOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawlerStoreOptions\"}]}}", isOptional: true)]
        public virtual object? StoreOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "parseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParseType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.aiSearchInstance.AiSearchInstanceSourceParamsWebCrawler\"}]}}", isOptional: true)]
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
                        case cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AiSearchInstance.IAiSearchInstanceSourceParamsWebCrawler).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
