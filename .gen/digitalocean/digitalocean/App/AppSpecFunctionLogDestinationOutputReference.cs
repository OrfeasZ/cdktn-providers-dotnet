using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecFunctionLogDestinationOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecFunctionLogDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecFunctionLogDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecFunctionLogDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppSpecFunctionLogDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecFunctionLogDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatadog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationDatadog\"}}]")]
        public virtual void PutDatadog(digitalocean.App.IAppSpecFunctionLogDestinationDatadog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionLogDestinationDatadog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogtail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationLogtail\"}}]")]
        public virtual void PutLogtail(digitalocean.App.IAppSpecFunctionLogDestinationLogtail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionLogDestinationLogtail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationOpenSearch\"}}]")]
        public virtual void PutOpenSearch(digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPapertrail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationPapertrail\"}}]")]
        public virtual void PutPapertrail(digitalocean.App.IAppSpecFunctionLogDestinationPapertrail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecFunctionLogDestinationPapertrail)}, new object[]{@value});
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

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationDatadogOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionLogDestinationDatadogOutputReference Datadog
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionLogDestinationDatadogOutputReference>()!;
        }

        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationLogtailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionLogDestinationLogtailOutputReference Logtail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionLogDestinationLogtailOutputReference>()!;
        }

        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationOpenSearchOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionLogDestinationOpenSearchOutputReference OpenSearch
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionLogDestinationOpenSearchOutputReference>()!;
        }

        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationPapertrailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecFunctionLogDestinationPapertrailOutputReference Papertrail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecFunctionLogDestinationPapertrailOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datadogInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationDatadog\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionLogDestinationDatadog? DatadogInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationDatadog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logtailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationLogtail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionLogDestinationLogtail? LogtailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationLogtail?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openSearchInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationOpenSearch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch? OpenSearchInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationOpenSearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "papertrailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestinationPapertrail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecFunctionLogDestinationPapertrail? PapertrailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecFunctionLogDestinationPapertrail?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecFunctionLogDestination\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecFunctionLogDestination cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecFunctionLogDestination).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
