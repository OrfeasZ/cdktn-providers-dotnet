using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciServiceCatalogAllApplications
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/service_catalog_all_applications oci_service_catalog_all_applications}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplications), fullyQualifiedName: "oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplications", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsConfig\"}}]")]
    public class DataOciServiceCatalogAllApplications : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/service_catalog_all_applications oci_service_catalog_all_applications} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciServiceCatalogAllApplications(Constructs.Construct scope, string id, oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciServiceCatalogAllApplications(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciServiceCatalogAllApplications(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciServiceCatalogAllApplications resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciServiceCatalogAllApplications to import.</param>
        /// <param name="importFromId">The id of the existing DataOciServiceCatalogAllApplications that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciServiceCatalogAllApplications to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciServiceCatalogAllApplications to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/service_catalog_all_applications#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciServiceCatalogAllApplications that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciServiceCatalogAllApplications to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplications), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEntityId")]
        public virtual void ResetEntityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEntityType")]
        public virtual void ResetEntityType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsFeatured")]
        public virtual void ResetIsFeatured()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageType")]
        public virtual void ResetPackageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPricing")]
        public virtual void ResetPricing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublisherId")]
        public virtual void ResetPublisherId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplications))!;

        [JsiiProperty(name: "applicationCollection", typeJson: "{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionList\"}")]
        public virtual oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionList ApplicationCollection
        {
            get => GetInstanceProperty<oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsApplicationCollectionList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsFilterList\"}")]
        public virtual oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsFilterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "entityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciServiceCatalogAllApplications.IDataOciServiceCatalogAllApplicationsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciServiceCatalogAllApplications.DataOciServiceCatalogAllApplicationsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isFeaturedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsFeaturedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageTypeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PackageTypeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pricingInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PricingInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publisherIdInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PublisherIdInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isFeatured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsFeatured
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

        [JsiiProperty(name: "packageType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PackageType
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pricing", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Pricing
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publisherId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublisherId
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
