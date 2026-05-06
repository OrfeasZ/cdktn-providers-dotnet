using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailSecurityTrustedDomains
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilterOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareEmailSecurityTrustedDomainsFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareEmailSecurityTrustedDomainsFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareEmailSecurityTrustedDomainsFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareEmailSecurityTrustedDomainsFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDirection")]
        public virtual void ResetDirection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRecent")]
        public virtual void ResetIsRecent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSimilarity")]
        public virtual void ResetIsSimilarity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrder")]
        public virtual void ResetOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPattern")]
        public virtual void ResetPattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearch")]
        public virtual void ResetSearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "directionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isRecentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRecentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSimilarityInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSimilarityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Direction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRecent
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

        [JsiiProperty(name: "isSimilarity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSimilarity
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

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Order
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pattern
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilter\"}]}}", isOptional: true)]
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
                        case cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsFilter cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsFilter).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
