using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountDnsSettingsInternalView
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAccountDnsSettingsInternalViewFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAccountDnsSettingsInternalViewFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAccountDnsSettingsInternalViewFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountDnsSettingsInternalViewFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putName", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterName\"}}]")]
        public virtual void PutName(cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilterName @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilterName)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDirection")]
        public virtual void ResetDirection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatch")]
        public virtual void ResetMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrder")]
        public virtual void ResetOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneId")]
        public virtual void ResetZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneName")]
        public virtual void ResetZoneName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference Name
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterNameOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MatchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterName\"}]}}", isOptional: true)]
        public virtual object? NameInput
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
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Direction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Match
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Order
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilter\"}]}}", isOptional: true)]
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
                        case cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilter cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilter).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
