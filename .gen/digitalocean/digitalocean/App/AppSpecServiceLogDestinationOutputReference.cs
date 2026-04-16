using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecServiceLogDestinationOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecServiceLogDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecServiceLogDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecServiceLogDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecServiceLogDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecServiceLogDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatadog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationDatadog\"}}]")]
        public virtual void PutDatadog(digitalocean.App.IAppSpecServiceLogDestinationDatadog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceLogDestinationDatadog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogtail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationLogtail\"}}]")]
        public virtual void PutLogtail(digitalocean.App.IAppSpecServiceLogDestinationLogtail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceLogDestinationLogtail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationOpenSearch\"}}]")]
        public virtual void PutOpenSearch(digitalocean.App.IAppSpecServiceLogDestinationOpenSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceLogDestinationOpenSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPapertrail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationPapertrail\"}}]")]
        public virtual void PutPapertrail(digitalocean.App.IAppSpecServiceLogDestinationPapertrail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceLogDestinationPapertrail)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDatadog")]
        public virtual void ResetDatadog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogtail")]
        public virtual void ResetLogtail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenSearch")]
        public virtual void ResetOpenSearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPapertrail")]
        public virtual void ResetPapertrail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationDatadogOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceLogDestinationDatadogOutputReference Datadog
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceLogDestinationDatadogOutputReference>()!;
        }

        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationLogtailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceLogDestinationLogtailOutputReference Logtail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceLogDestinationLogtailOutputReference>()!;
        }

        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationOpenSearchOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceLogDestinationOpenSearchOutputReference OpenSearch
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceLogDestinationOpenSearchOutputReference>()!;
        }

        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationPapertrailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceLogDestinationPapertrailOutputReference Papertrail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceLogDestinationPapertrailOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datadogInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationDatadog\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceLogDestinationDatadog? DatadogInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationDatadog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logtailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationLogtail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceLogDestinationLogtail? LogtailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationLogtail?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openSearchInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationOpenSearch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceLogDestinationOpenSearch? OpenSearchInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationOpenSearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "papertrailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationPapertrail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceLogDestinationPapertrail? PapertrailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceLogDestinationPapertrail?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestination\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecServiceLogDestination cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceLogDestination).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
