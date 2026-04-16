using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecWorkerLogDestinationOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecWorkerLogDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecWorkerLogDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecWorkerLogDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppSpecWorkerLogDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecWorkerLogDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatadog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationDatadog\"}}]")]
        public virtual void PutDatadog(digitalocean.App.IAppSpecWorkerLogDestinationDatadog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerLogDestinationDatadog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogtail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationLogtail\"}}]")]
        public virtual void PutLogtail(digitalocean.App.IAppSpecWorkerLogDestinationLogtail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerLogDestinationLogtail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationOpenSearch\"}}]")]
        public virtual void PutOpenSearch(digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPapertrail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationPapertrail\"}}]")]
        public virtual void PutPapertrail(digitalocean.App.IAppSpecWorkerLogDestinationPapertrail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecWorkerLogDestinationPapertrail)}, new object[]{@value});
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

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationDatadogOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerLogDestinationDatadogOutputReference Datadog
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerLogDestinationDatadogOutputReference>()!;
        }

        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationLogtailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerLogDestinationLogtailOutputReference Logtail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerLogDestinationLogtailOutputReference>()!;
        }

        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationOpenSearchOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerLogDestinationOpenSearchOutputReference OpenSearch
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerLogDestinationOpenSearchOutputReference>()!;
        }

        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationPapertrailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecWorkerLogDestinationPapertrailOutputReference Papertrail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecWorkerLogDestinationPapertrailOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datadogInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationDatadog\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerLogDestinationDatadog? DatadogInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationDatadog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logtailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationLogtail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerLogDestinationLogtail? LogtailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationLogtail?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openSearchInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationOpenSearch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch? OpenSearchInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationOpenSearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "papertrailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestinationPapertrail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecWorkerLogDestinationPapertrail? PapertrailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecWorkerLogDestinationPapertrail?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecWorkerLogDestination\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecWorkerLogDestination cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecWorkerLogDestination).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
