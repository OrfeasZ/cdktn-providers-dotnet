using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceLookup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup oci_log_analytics_namespace_lookup}.</summary>
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookup), fullyQualifiedName: "oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupConfig\"}}]")]
    public class LogAnalyticsNamespaceLookup : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup oci_log_analytics_namespace_lookup} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LogAnalyticsNamespaceLookup(Constructs.Construct scope, string id, oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceLookup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceLookup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LogAnalyticsNamespaceLookup resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LogAnalyticsNamespaceLookup to import.</param>
        /// <param name="importFromId">The id of the existing LogAnalyticsNamespaceLookup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LogAnalyticsNamespaceLookup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LogAnalyticsNamespaceLookup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/log_analytics_namespace_lookup#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LogAnalyticsNamespaceLookup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LogAnalyticsNamespaceLookup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCategories", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupCategories\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCategories(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupCategories[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupCategories).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupCategories).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LogAnalyticsNamespaceLookup.ILogAnalyticsNamespaceLookupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCategories")]
        public virtual void ResetCategories()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCharEncoding")]
        public virtual void ResetCharEncoding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultMatchValue")]
        public virtual void ResetDefaultMatchValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFields")]
        public virtual void ResetFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsHidden")]
        public virtual void ResetIsHidden()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxMatches")]
        public virtual void ResetMaxMatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookup))!;

        [JsiiProperty(name: "activeEditVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveEditVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "canonicalLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CanonicalLink
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "categories", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupCategoriesList\"}")]
        public virtual oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupCategoriesList Categories
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupCategoriesList>()!;
        }

        [JsiiProperty(name: "editVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EditVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fields", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFieldsList\"}")]
        public virtual oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFieldsList Fields
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFieldsList>()!;
        }

        [JsiiProperty(name: "isBuiltIn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsBuiltIn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lookupReferenceString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupReferenceString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referringSources", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupReferringSourcesList\"}")]
        public virtual oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupReferringSourcesList ReferringSources
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupReferringSourcesList>()!;
        }

        [JsiiProperty(name: "statusSummary", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupStatusSummaryList\"}")]
        public virtual oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupStatusSummaryList StatusSummary
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupStatusSummaryList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupTimeoutsOutputReference\"}")]
        public virtual oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoriesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupCategories\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CategoriesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "charEncodingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CharEncodingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultMatchValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultMatchValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isHiddenInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsHiddenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lookupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxMatchesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxMatchesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registerLookupFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegisterLookupFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.logAnalyticsNamespaceLookup.LogAnalyticsNamespaceLookupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "charEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharEncoding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultMatchValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultMatchValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsHidden
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

        [JsiiProperty(name: "lookupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxMatches", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxMatches
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registerLookupFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegisterLookupFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
