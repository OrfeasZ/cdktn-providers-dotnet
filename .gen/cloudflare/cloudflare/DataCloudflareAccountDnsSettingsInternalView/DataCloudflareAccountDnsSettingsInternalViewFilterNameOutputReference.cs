using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountDnsSettingsInternalView
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContains")]
        public virtual void ResetContains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndswith")]
        public virtual void ResetEndswith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExact")]
        public virtual void ResetExact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartswith")]
        public virtual void ResetStartswith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "containsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endswithInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndswithInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exactInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExactInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startswithInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartswithInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Contains
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endswith
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Exact
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Startswith
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterName\"}]}}", isOptional: true)]
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
                        case cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilterName cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilterName).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
