using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecJobLogDestinationOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecJobLogDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecJobLogDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecJobLogDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppSpecJobLogDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecJobLogDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatadog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationDatadog\"}}]")]
        public virtual void PutDatadog(digitalocean.App.IAppSpecJobLogDestinationDatadog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecJobLogDestinationDatadog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogtail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationLogtail\"}}]")]
        public virtual void PutLogtail(digitalocean.App.IAppSpecJobLogDestinationLogtail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecJobLogDestinationLogtail)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearch\"}}]")]
        public virtual void PutOpenSearch(digitalocean.App.IAppSpecJobLogDestinationOpenSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecJobLogDestinationOpenSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPapertrail", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationPapertrail\"}}]")]
        public virtual void PutPapertrail(digitalocean.App.IAppSpecJobLogDestinationPapertrail @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecJobLogDestinationPapertrail)}, new object[]{@value});
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

        [JsiiProperty(name: "datadog", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationDatadogOutputReference\"}")]
        public virtual digitalocean.App.AppSpecJobLogDestinationDatadogOutputReference Datadog
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecJobLogDestinationDatadogOutputReference>()!;
        }

        [JsiiProperty(name: "logtail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationLogtailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecJobLogDestinationLogtailOutputReference Logtail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecJobLogDestinationLogtailOutputReference>()!;
        }

        [JsiiProperty(name: "openSearch", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearchOutputReference\"}")]
        public virtual digitalocean.App.AppSpecJobLogDestinationOpenSearchOutputReference OpenSearch
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecJobLogDestinationOpenSearchOutputReference>()!;
        }

        [JsiiProperty(name: "papertrail", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationPapertrailOutputReference\"}")]
        public virtual digitalocean.App.AppSpecJobLogDestinationPapertrailOutputReference Papertrail
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecJobLogDestinationPapertrailOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datadogInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationDatadog\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecJobLogDestinationDatadog? DatadogInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationDatadog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logtailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationLogtail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecJobLogDestinationLogtail? LogtailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationLogtail?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openSearchInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecJobLogDestinationOpenSearch? OpenSearchInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationOpenSearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "papertrailInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationPapertrail\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecJobLogDestinationPapertrail? PapertrailInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationPapertrail?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecJobLogDestination\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecJobLogDestination cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecJobLogDestination).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
