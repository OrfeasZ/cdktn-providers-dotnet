using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalProduct
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product oci_oci_product_catalog_internal_product}.</summary>
    [JsiiClass(nativeType: typeof(oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProduct), fullyQualifiedName: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProduct", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductConfig\"}}]")]
    public class OciProductCatalogInternalProduct : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product oci_oci_product_catalog_internal_product} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OciProductCatalogInternalProduct(Constructs.Construct scope, string id, oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OciProductCatalogInternalProduct(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OciProductCatalogInternalProduct(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OciProductCatalogInternalProduct resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OciProductCatalogInternalProduct to import.</param>
        /// <param name="importFromId">The id of the existing OciProductCatalogInternalProduct that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OciProductCatalogInternalProduct to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OciProductCatalogInternalProduct to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OciProductCatalogInternalProduct that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OciProductCatalogInternalProduct to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProduct), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits" />)[]</param>
        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductLimits\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLimits(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters" />)[]</param>
        [JsiiMethod(name: "putMeters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductMeters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMeters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus" />)[]</param>
        [JsiiMethod(name: "putSkus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSkus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackfillEligibility")]
        public virtual void ResetBackfillEligibility()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsExcluded")]
        public virtual void ResetIsExcluded()
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

        [JsiiMethod(name: "resetSkus")]
        public virtual void ResetSkus()
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
        = GetStaticProperty<string>(typeof(oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProduct))!;

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductLimitsList\"}")]
        public virtual oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductLimitsList Limits
        {
            get => GetInstanceProperty<oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductLimitsList>()!;
        }

        [JsiiProperty(name: "meters", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductMetersList\"}")]
        public virtual oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductMetersList Meters
        {
            get => GetInstanceProperty<oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductMetersList>()!;
        }

        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skus", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkusList\"}")]
        public virtual oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductSkusList Skus
        {
            get => GetInstanceProperty<oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductSkusList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLaunched", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLaunched
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductTimeoutsOutputReference\"}")]
        public virtual oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OciProductCatalogInternalProduct.OciProductCatalogInternalProductTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeReady", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeReady
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backfillEligibilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackfillEligibilityInput
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isExcludedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsExcludedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LimitsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SkusInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "backfillEligibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackfillEligibility
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isExcluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsExcluded
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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
    }
}
