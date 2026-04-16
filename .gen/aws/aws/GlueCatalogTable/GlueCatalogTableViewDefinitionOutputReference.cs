using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable.GlueCatalogTableViewDefinitionOutputReference), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableViewDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueCatalogTableViewDefinitionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueCatalogTableViewDefinitionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueCatalogTableViewDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableViewDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRepresentations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRepresentations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefiner")]
        public virtual void ResetDefiner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsProtected")]
        public virtual void ResetIsProtected()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastRefreshType")]
        public virtual void ResetLastRefreshType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshSeconds")]
        public virtual void ResetRefreshSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepresentations")]
        public virtual void ResetRepresentations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubObjects")]
        public virtual void ResetSubObjects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubObjectVersionIds")]
        public virtual void ResetSubObjectVersionIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewVersionId")]
        public virtual void ResetViewVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewVersionToken")]
        public virtual void ResetViewVersionToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "representations", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentationsList\"}")]
        public virtual aws.GlueCatalogTable.GlueCatalogTableViewDefinitionRepresentationsList Representations
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.GlueCatalogTableViewDefinitionRepresentationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "definerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefinerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isProtectedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsProtectedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastRefreshTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastRefreshTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RefreshSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "representationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RepresentationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subObjectsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubObjectsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subObjectVersionIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? SubObjectVersionIdsInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewVersionIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ViewVersionIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewVersionTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewVersionTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "definer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Definer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsProtected
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

        [JsiiProperty(name: "lastRefreshType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRefreshType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refreshSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subObjects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubObjects
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subObjectVersionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] SubObjectVersionIds
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewVersionId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ViewVersionId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewVersionToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewVersionToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinition\"}", isOptional: true)]
        public virtual aws.GlueCatalogTable.IGlueCatalogTableViewDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.GlueCatalogTable.IGlueCatalogTableViewDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
