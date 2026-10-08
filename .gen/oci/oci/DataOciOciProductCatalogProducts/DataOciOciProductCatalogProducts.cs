using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOciProductCatalogProducts
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products oci_oci_product_catalog_products}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProducts), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProducts", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsConfig\"}}]")]
    public class DataOciOciProductCatalogProducts : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products oci_oci_product_catalog_products} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOciProductCatalogProducts(Constructs.Construct scope, string id, oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOciProductCatalogProducts(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOciProductCatalogProducts(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOciProductCatalogProducts resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOciProductCatalogProducts to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOciProductCatalogProducts that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOciProductCatalogProducts to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOciProductCatalogProducts to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOciProductCatalogProducts that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOciProductCatalogProducts to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProducts), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits" />)[]</param>
        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimits\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLimits(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters" />)[]</param>
        [JsiiMethod(name: "putMeters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMeters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleState")]
        public virtual void ResetLifecycleState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimit")]
        public virtual void ResetLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeters")]
        public virtual void ResetMeters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPage")]
        public virtual void ResetPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceName")]
        public virtual void ResetServiceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkusContains")]
        public virtual void ResetSkusContains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeReadyGreaterThanOrEqualTo")]
        public virtual void ResetTimeReadyGreaterThanOrEqualTo()
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
        = GetStaticProperty<string>(typeof(oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProducts))!;

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimitsList\"}")]
        public virtual oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimitsList Limits
        {
            get => GetInstanceProperty<oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimitsList>()!;
        }

        [JsiiProperty(name: "meters", typeJson: "{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMetersList\"}")]
        public virtual oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMetersList Meters
        {
            get => GetInstanceProperty<oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMetersList>()!;
        }

        [JsiiProperty(name: "products", typeJson: "{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsProductsList\"}")]
        public virtual oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsProductsList Products
        {
            get => GetInstanceProperty<oci.DataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsProductsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LifecycleStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LimitsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MetersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skusContainsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkusContainsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeReadyGreaterThanOrEqualToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeReadyGreaterThanOrEqualToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Limit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Page
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skusContains", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkusContains
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeReadyGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeReadyGreaterThanOrEqualTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
